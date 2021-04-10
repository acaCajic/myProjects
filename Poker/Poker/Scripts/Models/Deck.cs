using Poker.Scripts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker.Scripts.Models
{
    public enum CardSign { Diamond, Heart, Spade, Club }

    public struct Card
    {
        public int Number;
        public CardSign Sign;

        public Card(int num, CardSign sign)
        {
            Number = num;
            Sign = sign;
        }
    }

    public abstract class Deck : IDeck
    {
        public static Padding SELECTED_CARD_PADDING = new Padding(10);
        public static Padding NOT_SELECTED_CARD_PADDING = new Padding(2);

        public Dictionary<Card, PictureBox> Hand { get; protected set; }
        public Dictionary<Card, PictureBox> Cards { get; protected set; }
        public Dictionary<Card, PictureBox> CommunityCards { get; protected set; }

        public int Points { get; set; }
        public int Bet { get; set; }

        public abstract void CalculatePoints();
        public abstract void TestDraw();
        public abstract void ChangeCards(List<PictureBox> selectedPictures);

        public Deck()
        {
            LoadCards();
            Hand = new Dictionary<Card, PictureBox>();
        }

        public void Draw(int count)
        {
            Hand.Clear();
            Shuffle();
            for (int i = 0; i < count; i++)
            {
                Hand.Add(Cards.Keys.ElementAt(i), Cards.Values.ElementAt(i));
            }
        }

        public void PlaceBet()
        {
            Points -= Bet;
        }

        public abstract void DrawCommunityCards();

        private void Shuffle()
        {
            Random random = new Random();
            Cards = Cards.OrderBy(x => random.Next(random.Next())).ToDictionary(
                item => item.Key, item => item.Value);
        }

        protected PictureBox CreateCard(Stream stream)
        {
            PictureBox picture = new PictureBox
            {
                Image = Image.FromStream(stream),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
                Margin = NOT_SELECTED_CARD_PADDING,
                BorderStyle = BorderStyle.None
            };

            return picture;
        }

        protected void LoadCards()
        {
            Cards = new Dictionary<Card, PictureBox>();
            foreach (CardSign sign in (CardSign[])Enum.GetValues(typeof(CardSign)))
            {
                for (int number = 1; number <= 14; number++)
                {
                    if (number == 11)
                        number++;

                    using (Stream stream = Assembly.GetExecutingAssembly().
                        GetManifestResourceStream("Poker.Images." + number + sign + ".png"))
                    {
                        Cards.Add(new Card(number, sign), CreateCard(stream));
                    }
                }
            }
        }

        public PictureBox CreateFlipSideCard()
        {
            using (Stream stream = Assembly.GetExecutingAssembly().
                GetManifestResourceStream("Poker.Images.flip.jpg"))
            {
                PictureBox picture = new PictureBox
                {
                    Image = Image.FromStream(stream),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.None
                };

                return picture;
            }
        }
    }
}
