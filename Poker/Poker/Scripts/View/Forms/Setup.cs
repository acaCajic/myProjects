using Poker.Scripts.View.Interfaces;
using System.Windows.Forms;

namespace Poker.Scripts.View.Forms
{
    public partial class Setup : Form, ISetupView
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(PointsTextBox.Text, out int result))
            {

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        #region Properties

        public TextBox Points
        {
            get { return PointsTextBox; }
        }

        #endregion
    }
}
