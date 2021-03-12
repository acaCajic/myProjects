using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Controllers.Interfaces;
using System.Windows.Forms;
using MemoryGame.Model.Interfaces;
using MemoryGame.Views.Forms;
using MemoryGame.Views.Interfaces;
using MemoryGame.Model;

namespace MemoryGame.Controllers
{
    public  class TableController : ITableController
    {
        public const int CLOSING_CARDS_TIME = 1000;

        private ITable _view;
        private IData _pictures;

        private PictureBox _firstGuess;
        private PictureBox _secondGuess;
        private Timer _timer;
        private DateTime _start;
        private DateTime _end;

        public TableController(ITable view, IData configuration)
        {
            _view = view;
            _pictures = configuration;
            _view.SetController(this);
        }

        #region Events

        public void TableForm_Load()
        {
            DrawTable();
            CreateTimer();
        }

        public void LevelMenuItem_Click()
        {
            OptionsForm optionform = new OptionsForm();
            IOptionsController controller = new OptionsController(optionform, _pictures.Configuration);
            if (optionform.ShowDialog() == DialogResult.OK)
            {
                DrawTable();
            }
            else
                optionform.Close();
        }

        public void stopMenuItem_Click()
        {
            ShowClosedCards();
        }

        public void resetMenuItem_Click()
        {
            DrawTable();
            _pictures.OpenCards = 0;
        }

        #endregion

        #region Methodes

        public void DrawTable()
        {
            _view.table.Controls.Clear();
            DrawColumns(_pictures.Configuration.Columns);
            DrawRows(_pictures.Configuration.Rows);
            DrawItems();
            _start = DateTime.Now;
        }

        private void DrawItems()
        {
            _pictures.Update();

            for (int row = 0; row < _pictures.Configuration.Rows; row++)
            {
                for (int col = 0; col < _pictures.Configuration.Columns; col++)
                {
                    _view.table.Controls.Add(_pictures.DefaultPicture(), col, row);
                    _view.table.GetControlFromPosition(col, row).MouseClick +=
                        new MouseEventHandler(CellClicked);
                }
            }
        }

        private void CellClicked(object sender, MouseEventArgs e)
        {
            if (_firstGuess == null)
            {
                _firstGuess = OpenCard((PictureBox)sender);
                if (_firstGuess.Tag.Equals(Data.EMPTY_PICTURE_NAME))
                    _firstGuess = null;
            }
            else
            {
                _secondGuess = OpenCard((PictureBox)sender);
                if (_secondGuess.Tag.Equals(Data.EMPTY_PICTURE_NAME))
                    _secondGuess = null;
            }
            if (_firstGuess != null && _secondGuess != null)
            {
                if (!_firstGuess.Tag.Equals(_secondGuess.Tag))
                {
                    _view.table.Enabled = false;
                    _timer.Start();
                }
                else
                {
                    DeleteGuesses();
                    _pictures.OpenCards += 2;
                    if (_pictures.IsAllPicturesDiscovered())
                    {
                        ShowClosedCards();
                        _end = DateTime.Now;
                        MessageBox.Show((_end - _start).Seconds.ToString() + " seconds!", "Time");
                    }
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _view.table.Enabled = true;

            CloseCards(_firstGuess, _secondGuess);
            DeleteGuesses();

            _timer.Stop();
        }

        private void DrawRows(int rows)
        {
            _view.table.RowStyles.Clear();
            _view.table.RowCount = rows;

            float percent = 100f / rows;
            for (int i = 0; i < rows; i++)
            {
                _view.table.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
            }
        }

        private void DrawColumns(int columns)
        {
            _view.table.ColumnStyles.Clear();
            _view.table.ColumnCount = columns;

            float percent = 100f / columns;
            for (int i = 0; i < columns; i++)
            {
                _view.table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
            }
        }

        private PictureBox OpenCard(Control control)
        {
            TableLayoutPanelCellPosition cell = _view.table.GetPositionFromControl(control);

            _view.table.Controls.Remove(control);
            _view.table.Controls.Add(_pictures.Items[IndexOf(cell)], cell.Column, cell.Row);

            return _pictures.Items[IndexOf(cell)];
        }

        private void CloseCards(PictureBox firstGuess, PictureBox secondGuess)
        {
            TableLayoutPanelCellPosition firstGuessCell = _view.table.GetCellPosition(firstGuess);
            TableLayoutPanelCellPosition secondGuessCell = _view.table.GetCellPosition(secondGuess);

            _view.table.Controls.Remove(firstGuess);
            _view.table.Controls.Remove(secondGuess);

            _view.table.Controls.Add(_pictures.DefaultPicture(), firstGuessCell.Column, firstGuessCell.Row);
            _view.table.Controls.Add(_pictures.DefaultPicture(), secondGuessCell.Column, secondGuessCell.Row);

            _view.table.GetControlFromPosition(firstGuessCell.Column, firstGuessCell.Row).
                MouseClick += new MouseEventHandler(CellClicked);

            _view.table.GetControlFromPosition(secondGuessCell.Column, secondGuessCell.Row).
                MouseClick += new MouseEventHandler(CellClicked);
        }

        private void CreateTimer()
        {
            _timer = new Timer();
            _timer.Interval = CLOSING_CARDS_TIME;
            _timer.Tick += Timer_Tick;
        }

        private void DeleteGuesses()
        {
            _firstGuess = null;
            _secondGuess = null;
        }

        private void ShowClosedCards()
        {
            for (int row = 0; row < _pictures.Configuration.Rows; row++)
            {
                for (int col = 0; col < _pictures.Configuration.Columns; col++)
                {
                    Control control = GetControl(col, row);
                    if (control.Tag.Equals(Data.DEFAULT_PICTURE_NAME))
                    {
                        _view.table.Controls.Remove(control);
                        _view.table.Controls.Add(_pictures.GetPicture(col, row), col, row);
                    }
                }
            }
        }

        private int IndexOf(TableLayoutPanelCellPosition cell)
        {
            return cell.Row * _pictures.Configuration.Columns + cell.Column;
        }

        private Control GetControl(int col, int row)
        {
            return _view.table.GetControlFromPosition(col, row);
        }

        #endregion

    }
}
