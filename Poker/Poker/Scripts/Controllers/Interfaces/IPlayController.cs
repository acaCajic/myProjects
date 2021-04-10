using Poker.Scripts.Models.Interfaces;
using Poker.Scripts.View;

namespace Poker
{
    public interface IPlayController
    {
        void PlayForm_Load();
        void DealButton_Click();
        void ChangeButton_Click();
        void TexasHoldemMenuItem_Click();
        void EndMenuMenuItem_Click();
        void NewGameMenuItem_Click();
        void BetNumericUpDown_ValueChanged();
        void StandardMenuItem_Click();
    }
}