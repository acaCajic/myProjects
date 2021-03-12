using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Views.Interfaces;
using MemoryGame.Controllers.Interfaces;

namespace MemoryGame.Views.Forms
{
    public partial class OptionsForm : Form , IOptions
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private IOptionsController _controller;

        public void SetController(IOptionsController controller)
        {
            _controller = controller;
        }

        public int rows
        {
            get { return Convert.ToInt32(txtRows.Text); }
        }

        public int columns
        {
            get { return Convert.ToInt32(txtColumns.Text); }
        }

        public int pictures
        {
            get { return Convert.ToInt32(txtPictures.Text); }
        }

        public int pairs
        {
            get { return Convert.ToInt32(txtPairs.Text); }
        }

        public Form Form
        {
            get { return this; }
        }

        #region Evenets

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _controller.btnConfirm_Click();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }




        #endregion

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
