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
    public partial class UIBOM_Master : MetroFramework.Forms.MetroForm
    {
        private similanwms_nhkEntities db;
        private string _bom_id = string.Empty;
        private cls_bom_master oo_bom_master = new cls_bom_master();
        private cls_bom_details oo_bom_details = new cls_bom_details();
        
        //private DataTable dt_bom_details;
        public UIBOM_Master()
        {
            InitializeComponent();
        }

        public UIBOM_Master(string id)
        {
            InitializeComponent();
            _bom_id = id;
        }

        private void UIBOM_Master_Load(object sender, EventArgs e)
        {
            m_lbl_last_id.Text = oo_bom_details.last_id().ToString();
            show_id(_bom_id);
            show_bom_details();
        }

        private void show_id(string id)
        {
            //DataTable dt = oo_bom_master.show_by_id(id);
            //if (dt.Rows.Count > 0)
            //{
            //    m_txt_setcode.Text = dt.Rows[0][1].ToString();
            //    m_txt_desc.Text = dt.Rows[0][2].ToString();
            //    m_txt_version.Text = dt.Rows[0][3].ToString();
            //    m_txt_status.Text = dt.Rows[0][4].ToString();
            //    m_txt_currency.Text = dt.Rows[0][5].ToString();
            //    m_txt_maker.Text = dt.Rows[0][7].ToString();
            //}

            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.bom_master where c.setcode == id select c).ToList();
                foreach (var item in ds)
                {
                    m_txt_setcode.Text = item.setcode;
                    m_txt_desc.Text = item.description;
                    m_txt_version.Text = item.version;
                    m_txt_status.Text = item.status;
                    m_txt_currency.Text = item.currency;
                    m_txt_maker.Text = item.maker;
                }
            }

        }

        private void m_btn_save_Click(object sender, EventArgs e)
        {
            save_data();
        }

        private void save_data()
        {
            oo_bom_master.p_client = "NHK";
            oo_bom_master.p_setcode = m_txt_setcode.Text.Trim();
            oo_bom_master.p_description = m_txt_desc.Text.Trim();
            oo_bom_master.p_version = m_txt_version.Text.Trim();
            oo_bom_master.p_status = "ACTIVE";
            oo_bom_master.p_currency = "THB";
            oo_bom_master.p_standard_cost = "0.00";
            oo_bom_master.p_maker = "dksung";
            oo_bom_master.p_last_update = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt");
            oo_bom_master.p_create_by = "dksung";
            bool blnRet = oo_bom_master.add_bom_master();
            if (blnRet == true)
            {
                //MessageBox.Show("Finish");
                save_bom_details();
            }
            else
            {
                MessageBox.Show("save_data Error");
            }
        }

        private void show_bom_details()
        {
            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.bom_detail
                          where c.setcode == _bom_id
                          select new
                          {
                              c.client,
                              c.version,
                              c.item_no,
                              c.uom,
                              c.qty,
                              c.unit_cost,
                              c.total_cost,
                              c.maker,
                              c.last_update,
                              c.created_by,
                              c.created_date
                          }
                ).ToList();
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

        private void save_bom_details()
        {
            //oo_bom_details.p_setcode = m_txt_setcode.Text.Trim();
            //bool blnRet = oo_bom_details.add_bom_detials(dt_bom_details);
            //if (blnRet == true)
            //{
            //    MessageBox.Show("Finish");
            //}
            //else if (blnRet == false)
            //{
            //    MessageBox.Show("save_bom_details Error");
            //}

            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.bom_detail where c.setcode == m_txt_setcode.Text.Trim() select c).ToList();
                if (ds.Count > 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    for (int i = 0; i <= m_dgv.Rows.Count -1; i++)
                    {
                        db.bom_detail.Add(new bom_detail()
                        {
                            client = "NHK",
                            setcode = m_txt_setcode.Text.Trim(),
                            version = "1",
                            item_no = m_dgv.Rows[i].Cells[2].Value.ToString(),
                            uom = m_dgv.Rows[i].Cells[3].Value.ToString(),
                            qty = Convert.ToDecimal(m_dgv.Rows[i].Cells[4].Value.ToString()),
                            total_cost = Convert.ToDecimal(m_dgv.Rows[i].Cells[5].Value.ToString()),
                            unit_cost = Convert.ToDecimal(m_dgv.Rows[i].Cells[6].Value.ToString()),
                            maker = "dksung",
                            last_update = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt"),
                            created_by = "dksung",
                            created_date = DateTime.Now

                        });
                        db.SaveChanges();

                    }
                    MessageBox.Show("Finish");
                }

            }
        }
    }
}
