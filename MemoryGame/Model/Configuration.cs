using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Model.Interfaces;
using System.IO;
namespace MemoryGame.Model
{
    public class Configuration : IConfiguration
    {
        public const string CONFIG_PATH = "../../Resources/config.txt";
        public const int MIN_PICTURES = 6;
        public const int MIN_PAIRS = 10;
        public const int MIN_ROWS = 6;
        public const int MIN_COLUMNS = 10;
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int pairs;


        public int Pairs
        {
            get
            {
                int maxPairs = pairs;
                while (maxPairs * 2 + 1 > Rows * Columns)
                    maxPairs = maxPairs - 1;
                return maxPairs;
            }
            set
            {
                pairs = value;
            }
        }

        public int PicturesCount { get; set; }

        public Configuration()
        {
            if (!LoadFromFile())
            {
                Rows = MIN_ROWS;
                Columns = MIN_COLUMNS;
                Pairs = MIN_PAIRS;
                PicturesCount = MIN_PICTURES;
            }
        }

        public bool SaveToFile()
        {
            using (StreamWriter stream = new StreamWriter(CONFIG_PATH))
            {
                stream.WriteLine(Rows);
                stream.WriteLine(Columns);
                stream.WriteLine(Pairs);
                stream.WriteLine(PicturesCount);
                stream.Close();
                return true;
            }
        }

        public bool LoadFromFile()
        {
            bool result = true;
            using (StreamReader reader = new StreamReader(CONFIG_PATH))
            {
                int rows,columns,pairs,picturesCount;
                if (!int.TryParse(reader.ReadLine(), out  rows))
                    result = false;
                if (!int.TryParse(reader.ReadLine(), out  columns))
                    result = false;
                if (!int.TryParse(reader.ReadLine(), out  pairs))
                    result = false;
                if (!int.TryParse(reader.ReadLine(), out  picturesCount))
                    result = false;

                Rows = rows;
                Columns = columns;
                Pairs = pairs;
                PicturesCount = picturesCount;
            }
            return result;
        }
    }
}
