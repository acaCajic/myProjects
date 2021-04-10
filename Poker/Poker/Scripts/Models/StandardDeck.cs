using Poker.Scripts.Models.BusinessLogic;
using Poker.Scripts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker.Scripts.Models
{
    class StandardDeck : Deck
    {

        #region Constants

        public const int MAX_CARDS_IN_DECK = 52;
        public const int ONE_PAIR = 2;
        public const int TWO_PAIR = 4;
        public const int THREE_OF_A_KIND = 6;
        public const int BLAZE = 9;
        public const int STRAIGHT = 12;
        public const int FLUSH = 16;
        public const int FULL_HOUSE = 24;
        public const int BIG_BOBTAIL = 40;
        public const int FOUR_OF_A_KIND = 60;
        public const int STRAIGHT_FLUSH = 100;

        #endregion

        public override void CalculatePoints()
        {
            if (HandsChecker.StraightFlush(Hand.Keys.ToList()))
                Points += Bet * STRAIGHT_FLUSH;
            else if (HandsChecker.FourOfAKind(Hand.Keys.ToList()))
                Points += Bet * FOUR_OF_A_KIND;
            else if (HandsChecker.BigBobtail(Hand.Keys.ToList()))
                Points += Bet * BIG_BOBTAIL;
            else if (HandsChecker.FullHouse(Hand.Keys.ToList()))
                Points += Bet * FULL_HOUSE;
            else if (HandsChecker.Flush(Hand.Keys.ToList()))
                Points += Bet * FLUSH;
            else if (HandsChecker.Straight(Hand.Keys.ToList()))
                Points += Bet * STRAIGHT;
            else if (HandsChecker.Blaze(Hand.Keys.ToList()))
                Points += Bet * BLAZE;
            else if (HandsChecker.ThreeOfAKind(Hand.Keys.ToList()))
                Points += Bet * THREE_OF_A_KIND;
            else if (HandsChecker.TwoPairs(Hand.Keys.ToList()))
                Points += Bet * TWO_PAIR;
            else if (HandsChecker.OnePair(Hand.Keys.ToList()))
                Points += Bet * ONE_PAIR;
        }

        public override void TestDraw()
        {
            Hand.Clear();
            Hand.Add(Cards.Keys.ElementAt(0), Cards.Values.ElementAt(0));
            Hand.Add(Cards.Keys.ElementAt(1), Cards.Values.ElementAt(1));
            Hand.Add(Cards.Keys.ElementAt(2), Cards.Values.ElementAt(2));
            Hand.Add(Cards.Keys.ElementAt(3), Cards.Values.ElementAt(3));
            Hand.Add(Cards.Keys.ElementAt(16), Cards.Values.ElementAt(16));
        }

        public override void ChangeCards(List<PictureBox> selectedPictures)
        {
            int lastCardIndex = Cards.Count - 1;
            Dictionary<Card, PictureBox> newHand = new Dictionary<Card, PictureBox>();
            foreach (KeyValuePair<Card, PictureBox> pic in Hand)
            {
                newHand.Add(pic.Key, pic.Value);
            }
            foreach (PictureBox selected in selectedPictures)
            {
                foreach (KeyValuePair<Card, PictureBox> pictureInHand in Hand)
                {
                    if (pictureInHand.Value == selected)
                    {
                        newHand.Remove(pictureInHand.Key);
                        newHand.Add(Cards.Keys.ElementAt(lastCardIndex), Cards.Values.ElementAt(lastCardIndex));
                        lastCardIndex--;
                    }
                }
            }
            Hand = newHand;
        }

        public override void DrawCommunityCards()
        {
            throw new NotSupportedException();
        }
    }
}
