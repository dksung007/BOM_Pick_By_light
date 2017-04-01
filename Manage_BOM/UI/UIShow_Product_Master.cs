using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_BOM.Model;
using Manage_BOM.Class;

namespace Manage_BOM.UI
{
    public partial class UIShow_Product_Master : MetroFramework.Forms.MetroForm
    {
        private similanwms_nhkEntities db;
        private cls_Product_Master oo_Product_Master = new cls_Product_Master();
        private int _row_id;
        private string _bom_id = string.Empty;
        private cls_Common ooCommon = new cls_Common();
        public UIShow_Product_Master()
        {
            InitializeComponent();
        }

        private void UIShow_Product_Master_Load(object sender, EventArgs e)
        {
            show_data();
        }

        private void show_data()
        {
            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.product_master
                          where c.product_class == "ASSEMBLY"
                          orderby c.item_no
                          select new
                          {
                              c.row_id,
                              c.client,
                              c.item_no,
                              c.product_class,
                              c.description,
                              c.pick_seq,
                              c.default_grade,
                              c.status,
                              c.auto_zoning,
                              c.bonded_flag,
                              c.batch_no,
                              c.lot_no,
                              c.expiry_dt,
                              c.production_dt,
                              c.item_size,
                              c.item_class,
                              c.weight_required,
                              c.dimensions,
                              c.serial_no,
                              c.supplier,
                              c.owner,
                              c.country_origin,
                              c.nonstandard_pack,
                              c.remarks,
                              c.create_by,
                              c.create_date,
                              c.maker,
                              c.last_update,
                              c.min_pick_face,
                              c.Primary_Risk,
                              c.min_qty,
                              c.max_qty,
                              c.replenish_uom,
                              c.n_code
                          }).ToList();
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

        private void m_dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == m_dgv.Rows.Count)
            {
                return;
            }
            _row_id = Convert.ToInt32(m_dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            _bom_id = m_dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void m_btn_copy_bom_Click(object sender, EventArgs e)
        {
            ooCommon.p_UIProduct_Master = new UIProduct_Master(_bom_id);
            ooCommon.p_UIProduct_Master.ShowDialog();
            show_data();
        }

        private void m_btn_delete_Click(object sender, EventArgs e)
        {
            //if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete data yes or no ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    bool blnRet = oo_Product_Master.delete_product_master(_row_id);
            //    if (blnRet == true)
            //    {
            //        show_data();
            //    }
            //    else if (blnRet == false)
            //    {
            //        MetroFramework.MetroMessageBox.Show(this, "Delete data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void txt_find_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                find_data(txt_find.Text.Trim());
            }
        }

        private void find_data(string id)
        {
            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.product_master
                          where c.product_class == "ASSEMBLY"
                         where c.item_no.Contains(id)
                          select new
                          {
                              c.row_id,
                              c.client,
                              c.item_no,
                              c.product_class,
                              c.description,
                              c.pick_seq,
                              c.default_grade,
                              c.status,
                              c.auto_zoning,
                              c.bonded_flag,
                              c.batch_no,
                              c.lot_no,
                              c.expiry_dt,
                              c.production_dt,
                              c.item_size,
                              c.item_class,
                              c.weight_required,
                              c.dimensions,
                              c.serial_no,
                              c.supplier,
                              c.owner,
                              c.country_origin,
                              c.nonstandard_pack,
                              c.remarks,
                              c.create_by,
                              c.create_date,
                              c.maker,
                              c.last_update,
                              c.min_pick_face,
                              c.Primary_Risk,
                              c.min_qty,
                              c.max_qty,
                              c.replenish_uom,
                              c.n_code
                          }).ToList();
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
