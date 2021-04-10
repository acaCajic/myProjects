using Poker.Scripts.Models.Interfaces;
using System.Windows.Forms;

namespace Poker.Scripts.View
{
    public interface IPlayView
    {
        void SetController(IPlayController controller);

        Label Points { get; }
        NumericUpDown Bet { get; }

        TableLayoutPanel Hand { get; }
        TableLayoutPanel Board { get; }
        Button Change { get; }
    }
}
