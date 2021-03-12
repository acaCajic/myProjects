using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Model.Interfaces;

namespace MemoryGame.Model.Interfaces
{
    public interface IData
    {
        List<PictureBox> Icons { get; set; }
        List<PictureBox> Items { get; set; }

        IConfiguration Configuration { get; set; }

        int OpenCards { get; set; }

        PictureBox GetPicture(int col, int row);

        void Update();

        PictureBox DefaultPicture();
        PictureBox EmptyPicture();

        bool IsAllPicturesDiscovered();

    }
}
