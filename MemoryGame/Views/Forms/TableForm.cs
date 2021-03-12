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
    public partial class TableForm : Form , ITable
    {
        public TableForm()
        {
            InitializeComponent();
        }

        public TableLayoutPanel table
        {
            get { return tableLayout1; }
        }

        private ITableController _controller;
        public void SetController(ITableController controller)
        {
            _controller = controller;
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            _controller.TableForm_Load();
        }

        private void changeLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.LevelMenuItem_Click();
        }

        private void stopMenuItem_Click(object sender, EventArgs e)
        {
            _controller.stopMenuItem_Click();
        }

        private void resetMenuItem_Click(object sender, EventArgs e)
        {
            _controller.resetMenuItem_Click();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        
    }
}
