using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker.Scripts.Models.Interfaces
{
    public interface IDeck
    {
        Dictionary<Card, PictureBox> Hand { get; }
        Dictionary<Card, PictureBox> Cards { get; }
        Dictionary<Card, PictureBox> CommunityCards { get; }

        int Points { get; set; }
        int Bet { get; set; }

        void Draw(int count);
        void ChangeCards(List<PictureBox> selectedPictures);
        void PlaceBet();
        void CalculatePoints();
        void TestDraw();
        void DrawCommunityCards();
        PictureBox CreateFlipSideCard();
    }
}
