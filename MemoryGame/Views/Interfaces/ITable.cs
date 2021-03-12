using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Controllers.Interfaces;

namespace MemoryGame.Views.Interfaces
{
    public interface ITable
    {
        void SetController(ITableController controller);

        TableLayoutPanel table { get; }

      //  Button Stop { get; }
      //  Button Reset { get; }
    }
}
