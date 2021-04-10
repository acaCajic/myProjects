using Poker.Scripts.Models.Interfaces;
using Poker.Scripts.View;
using System.Windows.Forms;

namespace Poker
{
    public partial class PlayForm : Form, IPlayView
    {
        private IPlayController _controller;
        private IDeck _deck;

        public PlayForm()
        {
            InitializeComponent();
            typeof(TableLayoutPanel)
                .GetProperty("DoubleBuffered",
                 System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(CardsPanel, true, null);
        }

        public void SetController(IPlayController controller)
        {
            _controller = controller;
        }

        #region Properties


        public TableLayoutPanel Hand
        {
            get { return CardsPanel; }
        }

        public TableLayoutPanel Board
        {
            get { return CommunityCardsPanel; }
        }

        public Label Points
        {
            get { return PointsLbl; }
        }
        public NumericUpDown Bet
        {
            get { return BetNumericUpDown; }
        }

        public Button Change
        {
            get { return ChangeButton; }
        }

        #endregion

        #region Events

        private void PlayForm_Load(object sender, System.EventArgs e)
        {
            _controller.PlayForm_Load();
        }

        private void DealButton_Click(object sender, System.EventArgs e)
        {
            _controller.DealButton_Click();
        }

        private void ChangeButton_Click(object sender, System.EventArgs e)
        {
            _controller.ChangeButton_Click();
        }

        private void TexasHoldemMenuItem_Click(object sender, System.EventArgs e)
        {
            _controller.TexasHoldemMenuItem_Click();
        }

        private void EndMenuMenuItem_Click(object sender, System.EventArgs e)
        {
            _controller.EndMenuMenuItem_Click();
        }

        private void NewGameMenuItem_Click(object sender, System.EventArgs e)
        {
            _controller.NewGameMenuItem_Click();
        }

        private void ExitMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BetNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            _controller.BetNumericUpDown_ValueChanged();
        }

        #endregion

        private void StandardMenuItem_Click(object sender, System.EventArgs e)
        {
            _controller.StandardMenuItem_Click();
        }
    }
}
