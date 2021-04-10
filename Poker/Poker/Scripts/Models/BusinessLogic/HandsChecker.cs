using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Scripts.Models.BusinessLogic
{
    public static class HandsChecker
    {
        public static bool OnePair(List<Card> hand)
        {
            foreach (Card card in hand)
                if (hand.Count(item => item.Number == card.Number) == 2)
                    return true;
            return false;
        }

        public static bool TwoPairs(List<Card> hand)
        {
            if (hand.Count >= 4)
                if (hand.Select(card => card.Number).Distinct().Count() <= 3)
                    return true;
            return false;
        }

        public static bool ThreeOfAKind(List<Card> hand)
        {
            foreach (Card card in hand)
                if (hand.Count(item => item.Number == card.Number) == 3)
                    return true;
            return false;
        }

        public static bool Blaze(List<Card> hand)
        {
            if (hand.Count(item => item.Number >= 12) == 5)
                return true;
            return false;
        }

        public static bool Straight(List<Card> hand)
        {
            hand = Distinct(hand);
            if (hand.Count == 5 && hand.Max(card => card.Number) - hand.Min(card => card.Number) == 4)
                return true;

            Card ace = hand.Find(card => card.Number == 1);
            if (hand.Contains(ace))
            {
                hand.RemoveAt(hand.IndexOf(ace));
                ace.Number = 11;
                hand.Add(ace);
                return Straight(hand);
            }
            return false;
        }

        public static bool Flush(List<Card> hand)
        {
            if (hand.Count == 5)
            {
                foreach (Card item in hand)
                    if (hand.Count(card => card.Sign.Equals(item.Sign)) == 5)
                        return true;
            }
            return false;
        }

        public static bool FullHouse(List<Card> hand)
        {
            if (hand.Count == 5 && hand.Select(card => card.Number).Distinct().Count() == 2)
                return true;
            return false;
        }

        public static bool BigBobtail(List<Card> hand)
        {
            foreach (Card card in hand)
            {
                if (hand.Where(item => item.Sign.ToString() == card.Sign.ToString()).Count() >= 4)
                {
                    hand = hand.OrderByDescending(item => item.Number).ToList();
                    if (hand[0].Number - hand[3].Number == 3 || hand[1].Number - hand[4].Number == 3)
                        return true;
                }
            }
            return false;
        }

        public static bool FourOfAKind(List<Card> hand)
        {
            foreach (Card card in hand)
                if (hand.Count(item => item.Number == card.Number) == 4)
                    return true;
            return false;
        }

        public static bool StraightFlush(List<Card> hand)
        {
            if (Straight(hand) && Flush(hand))
                return true;
            return false;
        }

        public static bool BigDog(List<Card> hand)
        {
            hand = Distinct(hand);
            if (hand.Count == 5 && hand.Contains(hand.Find(card => card.Number == 1)))
            {
                hand.Remove(hand.Find(card => card.Number == 1));
                if (hand.Min(card => card.Number) >= 9 && hand.Max(card => card.Number) <= 14)
                    return true;
            }
            return false;
        }

        public static bool LittleDog(List<Card> hand)
        {
            hand = Distinct(hand);
            if (hand.Count == 5 && hand.Min(card => card.Number) >= 2 && hand.Max(card => card.Number) <= 7)
                return true;
            return false;
        }

        public static bool BobtailStraight(List<Card> hand)
        {
            hand = hand.OrderByDescending(card => card.Number).ToList();
            if (Math.Abs(hand[0].Number - hand[3].Number) == 3 || Math.Abs(hand[1].Number - hand[4].Number) == 3)
                return true;
            return false;
        }

        private static List<Card> Distinct(List<Card> list)
        {
            List<Card> result = new List<Card>();
            foreach (Card card in list)
            {
                bool contain = false;
                foreach (Card item in result)
                {
                    if (item.Number == card.Number)
                        contain = true;
                }
                if (!contain)
                    result.Add(card);
            }
            return result;
        }
    }
}
