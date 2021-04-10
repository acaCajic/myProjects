using Poker.Scripts.Controllers.Interfaces;
using Poker.Scripts.Models;
using Poker.Scripts.Models.Interfaces;
using Poker.Scripts.View;
using Poker.Scripts.View.Forms;
using System.Windows.Forms;

namespace Poker.Scripts.Controllers
{
    class PlayController : IPlayController
    {
        private IPlayView _view;
        private IDeck _deck;
        private IModeController _modeController;

        public PlayController(IPlayView view, IDeck deck)
        {
            _view = view;
            _deck = deck;
            _view.SetController(this);
            _modeController = new StandardController(_view, _deck);
        }

        public void ChangeButton_Click()
        {
            _modeController.ChangeButton_Click();
            _view.Bet.Enabled = true;
            if (_deck.Points == 0)
                MessageBox.Show("Game is over! Start new game!", "Game over");
        }

        public void DealButton_Click()
        {
            if (!_deck.Points.ToString().Equals("0"))
            {
                _deck.Bet = (int)_view.Bet.Value;
                _deck.PlaceBet();
                _view.Points.Text = _deck.Points.ToString();
                _view.Bet.Enabled = false;

                _modeController.DealButton_Click();
            }
        }

        public void PlayForm_Load()
        {
            LoadData();
        }

        public void TexasHoldemMenuItem_Click()
        {
            _deck = new FrenchDeck();
            _modeController = new FrenchController(_view, _deck);
            if (LoadData())
            {
                RedrawForTexasHoldem();
            }
        }

        public void StandardMenuItem_Click()
        {
            _deck = new StandardDeck();
            _modeController = new StandardController(_view, _deck);
            if (LoadData())
            {
                RedrawForStandard();
            }
        }

        private void RedrawForTexasHoldem()
        {
            _view.Hand.Controls.Clear();
            _view.Hand.ColumnCount = 2;
            _view.Hand.Size = new System.Drawing.Size(200, 100);
            _view.Hand.Location = new System.Drawing.Point(212, 329);
            _view.Bet.Value = _view.Bet.Minimum;
            _view.Points.Text = _deck.Points.ToString();
            _view.Change.Text = "Done";
            _view.Change.Enabled = true;
        }

        private void RedrawForStandard()
        {
            _view.Hand.Controls.Clear();
            _view.Board.Controls.Clear();
            _view.Hand.ColumnCount = 5;
            _view.Hand.Size = new System.Drawing.Size(400, 100);
            _view.Hand.Location = new System.Drawing.Point(112, 329);
            _view.Bet.Value = _view.Bet.Minimum;
            _view.Points.Text = _deck.Points.ToString();
            _view.Change.Text = "Change / Done";
            _view.Change.Enabled = true;
        }

        private bool LoadData()
        {
            Setup setupForm = new Setup();
            setupForm.ShowDialog();

            if (setupForm.DialogResult == DialogResult.OK)
            {
                _deck.Points = int.Parse(setupForm.Points.Text);
                _view.Points.Text = _deck.Points.ToString();
                _view.Bet.Maximum = _deck.Points;
                return true;
            }
            return false;
        }

        public void EndMenuMenuItem_Click()
        {
            _view.Hand.Controls.Clear();
            _view.Board.Controls.Clear();
            _deck.Points = 0;
            _view.Points.Text = _deck.Points.ToString();
            _view.Bet.Value = _view.Bet.Minimum;
        }

        public void NewGameMenuItem_Click()
        {
            LoadData();
        }

        public void BetNumericUpDown_ValueChanged()
        {
            _deck.Bet = (int)_view.Bet.Value;
        }

    }
}
