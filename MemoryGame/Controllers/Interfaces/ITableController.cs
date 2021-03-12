using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Controllers.Interfaces
{
    public interface ITableController
    {
        void TableForm_Load();
        void LevelMenuItem_Click();

        void resetMenuItem_Click();
        void stopMenuItem_Click();
    }
}
