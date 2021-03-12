using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Controllers.Interfaces;

namespace MemoryGame.Views.Interfaces
{
    public interface IOptions
    {
        void SetController(IOptionsController controller);

        int rows { get; }
        int columns { get; }
        int pairs { get; }
        int pictures { get; }
        Form Form { get; }

      //  Button Confirim { get; }

     //   Button Close { get; }
    }
}
