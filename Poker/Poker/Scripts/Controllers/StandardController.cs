using Poker.Scripts.Controllers.Interfaces;
using Poker.Scripts.Models;
using Poker.Scripts.Models.Interfaces;
using Poker.Scripts.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poker.Scripts.Controllers
{
    public class StandardController : IModeController
    {
        private const int MAX_CARD_IN_HAND = 5;
        private const int MAX_SELECTED_CARD = 3;

        private IPlayView _view;
        private IDeck _deck;

        private List<PictureBox> _selectedCards;

        public StandardController(IPlayView view, IDeck deck)
        {
            _view = view;
            _deck = deck;
        }

        #region Events

        public void DealButton_Click()
        {
            _selectedCards = new List<PictureBox>();

            _deck.Draw(MAX_CARD_IN_HAND);
            ShowCardsInHand();
            _view.Change.Enabled = true;
        }

        private void Picture_MouseClick(object sender, MouseEventArgs e)
        {
            if (((PictureBox)sender).Margin == StandardDeck.NOT_SELECTED_CARD_PADDING)
            {
                ((PictureBox)sender).Margin = StandardDeck.SELECTED_CARD_PADDING;
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
                _selectedCards.Add((PictureBox)sender);
            }
            else
            {
                ((PictureBox)sender).Margin = StandardDeck.NOT_SELECTED_CARD_PADDING;
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
                _selectedCards.Remove((PictureBox)sender);
            }
        }

        public void ChangeButton_Click()
        {
            if (_selectedCards.Count <= MAX_SELECTED_CARD)
            {
                _deck.ChangeCards(_selectedCards);
                ShowCardsInHand();
                _view.Change.Enabled = false;
                _deck.CalculatePoints();
                UpdatePointsTextBox();
            }
        }

        #endregion

        #region Functions

        private void UpdatePointsTextBox()
        {
            _view.Points.Text = _deck.Points.ToString();
        }

        private void ShowCardsInHand()
        {
            _view.Hand.Controls.Clear();
            foreach (PictureBox picture in _deck.Hand.Values)
            {
                picture.Margin = StandardDeck.NOT_SELECTED_CARD_PADDING;
                picture.BorderStyle = BorderStyle.None;

                _view.Hand.Controls.Add(picture);

                picture.MouseClick -= Picture_MouseClick;
                picture.MouseClick += Picture_MouseClick;
            }
        }


        #endregion
    }
}
