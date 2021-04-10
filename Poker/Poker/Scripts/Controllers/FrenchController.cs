using Poker.Scripts.Controllers.Interfaces;
using Poker.Scripts.Models.Interfaces;
using Poker.Scripts.View;
using System.Linq;
using System.Windows.Forms;

namespace Poker.Scripts.Controllers
{
    public class FrenchController : IModeController
    {
        private const int MAX_CARD_IN_HAND = 2;

        private IPlayView _view;
        private IDeck _deck;

        public FrenchController(IPlayView view, IDeck deck)
        {
            _view = view;
            _deck = deck;
        }

        public void ChangeButton_Click()
        {
            _deck.CalculatePoints();
            _view.Points.Text = _deck.Points.ToString();
            _view.Board.Controls.Clear();
            _view.Hand.Controls.Clear();
            _deck.Hand.Clear();
        }

        public void DealButton_Click()
        {
            _deck.Draw(MAX_CARD_IN_HAND);
            _deck.DrawCommunityCards();
            ShowCardsInHand();
            ShowCardsOnBoard();
        }

        private void ShowCardsInHand()
        {
            _view.Hand.Controls.Clear();
            foreach (PictureBox picture in _deck.Hand.Values)
            {
                _view.Hand.Controls.Add(picture);
                if (picture.Image == null)
                {
                    int a = 0;
                }
            }
        }

        private void ShowCardsOnBoard()
        {
            _view.Board.Controls.Clear();

            _view.Board.Controls.Add(_deck.CreateFlipSideCard(), 0, 0);
            _view.Board.GetControlFromPosition(0, 0).MouseClick += P_MouseClick;

            _view.Board.Controls.Add(_deck.CreateFlipSideCard(), 1, 0);
            _view.Board.Controls.Add(_deck.CreateFlipSideCard(), 2, 0);
        }

        private void P_MouseClick(object sender, MouseEventArgs e)
        {
            TableLayoutPanelCellPosition cell = _view.Board.GetCellPosition((PictureBox)sender);

            _view.Board.Controls.Remove((Control)sender);
            _view.Board.Controls.Add(_deck.CommunityCards.Values.ElementAt(cell.Column), cell.Column, cell.Row);

            if (cell.Column != 2 && _deck.Points >= _deck.Bet)
                _view.Board.GetControlFromPosition(cell.Column + 1, 0).MouseClick += P_MouseClick;

            _deck.Hand.Add(_deck.CommunityCards.ElementAt(cell.Column).Key, _deck.CommunityCards.ElementAt(cell.Column).Value);

            if (_deck.Hand.Count == 4 && _deck.Points >= _deck.Bet * 2)
            {
                _deck.Points -= (int)_view.Bet.Value;
                _deck.Bet += (int)_view.Bet.Value;
                _view.Points.Text = _deck.Points.ToString();
            }
            if (_deck.Hand.Count == 5)
            {
                _deck.Points -= 2 * (int)_view.Bet.Value;
                _deck.Bet += 2 * (int)_view.Bet.Value;
                _view.Points.Text = _deck.Points.ToString();
            }

        }
    }
}
