using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Controllers.Interfaces;
using MemoryGame.Views.Interfaces;
using MemoryGame.Model.Interfaces;
using System.Windows.Forms;
namespace MemoryGame.Controllers
{
    public class OptionsController : IOptionsController
    {
        IOptions _view;
        IConfiguration _config;

        public OptionsController(IOptions view, IConfiguration model)
        {
            _view = view;
            _config = model;
            _view.SetController(this);
        }

        public void SubmitButton_Click()
        {
            _config.Rows = _view.rows;
            _config.Columns = _view.columns;
            _config.Pairs = _view.pairs;
            _config.PicturesCount = _view.pictures;

            _config.SaveToFile();

            _view.Form.DialogResult = DialogResult.OK;
           // _view.Form.Close();
        }
        public void btnConfirm_Click()
        {
            SubmitButton_Click();
        }
    }
}
