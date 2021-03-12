using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Model.Interfaces;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace MemoryGame.Model
{
    public class Data : IData
    {
        #region Atributes

        //private static int rowCount = 6;
        //private static int columnnCount = 10;

        //public static int RowCount
        //{
        //    get { return rowCount; }
        //    set { rowCount = value; }
        //}
        //public static int ColumnCount
        //{
        //    get { return columnnCount; }
        //    set { columnnCount = value; }
        //}

        public const string DEFAULT_PICTURE_NAME = "default";
        public const string EMPTY_PICTURE_NAME = "empty";


        public List<PictureBox> Icons { get; set; }
        public List<PictureBox> Items { get; set; }

        public IConfiguration Configuration { get; set; }

        public int OpenCards { get; set; }

        #endregion

        #region Methodes

        public Data()
        {
            Configuration = new Configuration();
            OpenCards = 0;
            Update();
        }

        public void Update()
        {
            CreateIconsList();
            CreateItemsList();
            Shuffle();
        }
//
        private void CreateIconsList()
        {
            Icons = new List<PictureBox>();
            for(int i=0; i< Configuration.PicturesCount; i++)
            {
                PictureBox picture = CreatePicture(i);
                Icons.Add(picture);
            }
        }
        private void CreateItemsList()
        {
            Items = new List<PictureBox>();
            CreatePairs();
            for (int index = 2 * Configuration.Pairs; index < Configuration.Rows * Configuration.Columns; index++)
            {
                Items.Add(EmptyPicture());
            }
        }

        private PictureBox CreatePicture(int name)
        {
            PictureBox picture = new PictureBox
            {
                Image = Image.FromFile(GetImagesPath() + name + ".png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
                Margin = new Padding(5),
                Tag = name
            };
            return picture;
        }

        public PictureBox DefaultPicture()
        {
            PictureBox picture = new PictureBox
            {
                Image = Image.FromFile(GetImagesPath() + DEFAULT_PICTURE_NAME + ".png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
                Tag = DEFAULT_PICTURE_NAME
            };
            return picture;
        }

        public PictureBox EmptyPicture()
        {
            PictureBox picture = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
                Tag = EMPTY_PICTURE_NAME
            };

            return picture;
        }

        private void CreatePair(int name)
        {
            Items.Add(CreatePicture(name));
            Items.Add(CreatePicture(name));
        }

        private void CreatePairs()
        {
            int pairs = 0;
            int pictureIndex = 0;
            while (pairs < Configuration.Pairs)
            {
                CreatePair(pictureIndex);
                pairs++;
                pictureIndex++;
                if (pictureIndex >= Configuration.PicturesCount)
                    pictureIndex = 0;
            }
        }

        private void Shuffle()
        {
            Random random = new Random();
            int count = Items.Count;
            while (count > 1)
            {
                count--;
                int k = random.Next(count + 1);
                PictureBox value = Items[k];
                Items[k] = Items[count];
                Items[count] = value;
            }
        }

        public bool IsAllPicturesDiscovered()
        {
            return OpenCards >= (2 * Configuration.Pairs);
        }

        public PictureBox GetPicture(int col, int row)
        {
            return Items[row * Configuration.Columns + col];
        }

        private string GetImagesPath()
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            return Path.Combine(projectPath, "Resources//");
        }

        #endregion

    }
}