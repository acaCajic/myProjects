using Poker.Scripts.Models.BusinessLogic;
using Poker.Scripts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Poker.Scripts.Models
{
    class FrenchDeck : Deck
    {
        public const int MAX_CARDS_IN_DECK = 52;
        public const int TWO_CARDS_BONUS = 5;
        public const int THREE_CARDS_BONUS = 2;

        #region Constants

        public const int ONE_PAIR = 1;
        public const int TWO_PAIR = 5;
        public const int THREE_OF_A_KIND = 8;
        public const int BOBTIAL_STRAIGHT = 12;
        public const int LITTLE_DOG = 18;
        public const int STRAIGHT = 26;
        public const int FLUSH = 40;
        public const int BIG_DOG = 60;
        public const int FOUR_OF_A_KIND = 90;
        public const int STRAIGHT_FLUSH = 150;

        #endregion

        public FrenchDeck()
        {
            CommunityCards = new Dictionary<Card, PictureBox>();
        }

        public override void CalculatePoints()
        {
            int newBet = Bet;
            if (Hand.Count == 2)
                newBet = Bet * TWO_CARDS_BONUS;
            else if (Hand.Count == 3)
                newBet = Bet * THREE_CARDS_BONUS;

            if (HandsChecker.StraightFlush(Hand.Keys.ToList()))
                Points += newBet * STRAIGHT_FLUSH;
            else if (HandsChecker.FourOfAKind(Hand.Keys.ToList()))
                Points += newBet * FOUR_OF_A_KIND;
            else if (HandsChecker.BigDog(Hand.Keys.ToList()))
                Points += newBet * BIG_DOG;
            else if (HandsChecker.Flush(Hand.Keys.ToList()))
                Points += newBet * FLUSH;
            else if (HandsChecker.Straight(Hand.Keys.ToList()))
                Points += newBet * STRAIGHT;
            else if (HandsChecker.LittleDog(Hand.Keys.ToList()))
                Points += newBet * LITTLE_DOG;
            else if (HandsChecker.BobtailStraight(Hand.Keys.ToList()))
                Points += newBet * BOBTIAL_STRAIGHT;
            else if (HandsChecker.ThreeOfAKind(Hand.Keys.ToList()))
                Points += newBet * THREE_OF_A_KIND;
            else if (HandsChecker.TwoPairs(Hand.Keys.ToList()))
                Points += newBet * TWO_PAIR;
            else if (HandsChecker.OnePair(Hand.Keys.ToList()))
                Points += newBet * ONE_PAIR;
        }

        public override void ChangeCards(List<PictureBox> selectedPictures)
        {
            throw new NotSupportedException();
        }

        public override void DrawCommunityCards()
        {
            CommunityCards.Clear();
            for (int i = 10; i < 13; i++)
            {
                CommunityCards.Add(Cards.Keys.ElementAt(i), Cards.Values.ElementAt(i));
            }
        }

        public override void TestDraw()
        {

        }
    }
}