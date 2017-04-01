using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_BOM.UI
{
    public partial class UIBOM_Details : MetroFramework.Forms.MetroForm
    {
        private string _bom_id = string.Empty;
        public UIBOM_Details()
        {
            InitializeComponent();
        }

        public UIBOM_Details(string id)
        {
            InitializeComponent();
            _bom_id = id;
        }

        private void UIBOM_Details_Load(object sender, EventArgs e)
        {

        }


    }
}
