using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Views.Forms;
using MemoryGame.Model.Interfaces;
using MemoryGame.Model;
using MemoryGame.Controllers.Interfaces;
using MemoryGame.Controllers;

namespace MemoryGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TableForm view = new TableForm();
            IData configuration = new Data();
            ITableController controller = new TableController(view, configuration);

            Application.Run(view);
        }
    }
}
