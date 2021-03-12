using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Model.Interfaces
{
    public interface IConfiguration
    {
        int Rows { get; set; }
        int Columns { get; set; }
        int Pairs { get; set; }
        int PicturesCount { get; set; }
        bool SaveToFile();
        bool LoadFromFile();

    }
}
