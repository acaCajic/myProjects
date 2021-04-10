using Poker.Scripts.Controllers;
using Poker.Scripts.Models;
using Poker.Scripts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PlayForm view = new PlayForm();
            IDeck model = new StandardDeck();
            IPlayController controller = new PlayController(view, model);
            Application.Run(view);
        }
    }
}
