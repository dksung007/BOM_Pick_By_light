using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_BOM.Class;


namespace Manage_BOM.UI
{
    public partial class UIMain : MetroFramework.Forms.MetroForm
    {
        private cls_Common ooCommon = new cls_Common();
        public UIMain()
        {
            InitializeComponent();
        }

        private void UIMain_Load(object sender, EventArgs e)
        {

        }

        private void mt_product_master_Click(object sender, EventArgs e)
        {
            ooCommon.p_UIShow_Product_Master = new UIShow_Product_Master();
            ooCommon.p_UIShow_Product_Master.ShowDialog();

        }

        private void mt_bom_master_Click(object sender, EventArgs e)
        {
            ooCommon.p_UIShow_BOM_Master = new UIShow_BOM_Master();
            ooCommon.p_UIShow_BOM_Master.ShowDialog();
        }
    }
}
