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
using Manage_BOM.Model;
namespace Manage_BOM.UI
{
    public partial class UIShow_BOM_Master : MetroFramework.Forms.MetroForm
    {
        private similanwms_nhkEntities db;
        private cls_Common ooCommon = new cls_Common();
        private string _bom_id = string.Empty;
        private cls_bom_master oo_bom_master = new cls_bom_master();
        private cls_bom_details oo_bom_detials = new cls_bom_details();

        public UIShow_BOM_Master()
        {
            InitializeComponent();
        }

        private void UIShow_BOM_Master_Load(object sender, EventArgs e)
        {
            show_bom_master();
        }

        private void show_bom_master()
        {
            //DataTable dt = ooshow_bom_master.show_bom_master();
            //if (dt.Rows.Count > 0)
            //{
            //    m_dgv.DataSource = dt;
            //}
            //else
            //{
            //    m_dgv.DataSource = null;
            //}


            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.bom_master orderby c.setcode select c).ToList();
                if (ds.Count > 0)
                {
                    m_dgv.DataSource = ds;
                }
                else
                {
                    m_dgv.DataSource = null;
                }
            }
        }

        private void m_btn_copy_bom_Click(object sender, EventArgs e)
        {
          
            ooCommon.p_UIBOM_Master = new UIBOM_Master(_bom_id);
            ooCommon.p_UIBOM_Master.ShowDialog();
            show_bom_master();
        }

        private void m_dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == m_dgv.Rows.Count)
            {
                return;
            }
            _bom_id = m_dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void m_btn_delete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete data yes or no ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool blnRet = oo_bom_master.delete_bom_master(_bom_id);
                if (blnRet == true)
                {
                    delete_bom_details();
                }
                else if (blnRet == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Delete data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delete_bom_details()
        {

            bool blnRet = oo_bom_detials.delete_bom_details(_bom_id);
            if (blnRet == true)
            {
                show_bom_master();
            }
            else if (blnRet == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Delete BOM Details Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //using (db = new similanwms_nhkEntities())
            //{
            //    var ds = (from c in db.bom_detail where c.setcode == _bom_id select c).ToList();
            //    for (int i = 0; i < ds.Count; i++)
            //    {
            //        db.bom_detail.Remove(ds[i]);
            //        db.SaveChanges();
            //    }
            //}
        }

        private void txt_find_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                find_bom_master(txt_find.Text.Trim());
            }
        }

        private void find_bom_master(string id)
        {
            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.bom_master where c.setcode.Contains(id) select c).ToList();
                if (ds.Count > 0)
                {
                    m_dgv.DataSource = ds;
                }
                else
                {
                    m_dgv.DataSource = null;
                }
            }
        }
    }
}
