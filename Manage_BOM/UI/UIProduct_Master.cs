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
    public partial class UIProduct_Master : MetroFramework.Forms.MetroForm
    {
        private similanwms_nhkEntities db;
        private string bom_id = string.Empty;
        private cls_Product_Master ooProduct_Master = new cls_Product_Master();
        public UIProduct_Master()
        {
            InitializeComponent();
        }

        public UIProduct_Master(string ID)
        {
            InitializeComponent();
            bom_id = ID;
        }

        private void UIProduct_Master_Load(object sender, EventArgs e)
        {
            show_data(bom_id);
            metroLabel1.Text = Convert.ToString(ooProduct_Master.auto_id() + 1);
            //metroTextBox1.Text = bom_id;
            show_product_uom(bom_id);
        }

        private void show_data(string id)
        {
            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.product_master
                          where c.item_no == id
                          select new
                          {
                              c.item_no,
                              c.product_class,
                              c.description,
                              c.pick_seq,
                              c.status,
                              c.maker,
                              c.min_pick_face,
                              c.max_pick_face,
                              c.default_grade
                          }).ToList();
                foreach (var item in ds)
                {
                    m_txt_item_no.Text = item.item_no;
                    m_txt_desc.Text = item.description;
                    m_txt_pick_seq.Text = item.pick_seq;
                    m_txt_status.Text = item.status;
                    m_txt_deault_grade.Text = item.default_grade;
                    m_txt_product_class.Text = item.product_class;
                    m_txt_max_pick_face.Text = item.max_pick_face.ToString();
                    m_txt_min_pick_face.Text = item.min_pick_face.ToString();
                }
            }
        }

        private void m_btn_save_Click(object sender, EventArgs e)
        {
            save_data();
        }

        private void save_data()
        {
            ooProduct_Master.p_item_no = m_txt_item_no.Text.Trim();
            ooProduct_Master.p_product_class = m_txt_product_class.Text.Trim();
            ooProduct_Master.p_desription = m_txt_desc.Text.Trim();
            ooProduct_Master.p_min_pick_face = Convert.ToDecimal(m_txt_min_pick_face.Text.Trim());
            ooProduct_Master.p_max_pick_face = Convert.ToDecimal(m_txt_max_pick_face.Text.Trim());
            ooProduct_Master.p_status = m_txt_status.Text.Trim();
            ooProduct_Master.p_defult_grade = m_txt_deault_grade.Text.Trim();
            ooProduct_Master.p_pick_seq = m_txt_pick_seq.Text.Trim();

            ooProduct_Master.p_rows_id = ooProduct_Master.auto_id() + 1;
            ooProduct_Master.p_client = "NHK";
            ooProduct_Master.p_auto_zoning = "N";
            ooProduct_Master.p_bonded_flag = "N";
            ooProduct_Master.p_batch_no = "N";
            ooProduct_Master.p_lot_no = "N";
            ooProduct_Master.p_expiry_dt = "N";
            ooProduct_Master.p_production_dt = "N";
            ooProduct_Master.p_item_size = "N";
            ooProduct_Master.p_item_class = "N";
            ooProduct_Master.p_weight_required = "N";
            ooProduct_Master.p_dimensions = "N";
            ooProduct_Master.p_serail_no = "N";
            ooProduct_Master.p_supplier = "N";
            ooProduct_Master.p_owner = "N";
            ooProduct_Master.p_country_origin = "N";
            ooProduct_Master.p_nonstandard_pack = "N";
            ooProduct_Master.p_remarks = "Copy BOM";
            ooProduct_Master.p_create_by = "dksung";
            ooProduct_Master.p_create_date = DateTime.Now;
            ooProduct_Master.p_maker = "dksung";
            ooProduct_Master.p_last_update = DateTime.Now;
            ooProduct_Master.p_Primary_Risk = "-";
            ooProduct_Master.p_replenish_uom = "PCS";
            ooProduct_Master.p_n_code = m_txt_item_no.Text.Trim();
            bool blnRet = ooProduct_Master.add_product_master();
            if (blnRet == true)
            {
                add_product_zoning();
                add_product_barcode();
                add_product_uom();
                add_product_uom_temp();
                //MessageBox.Show("Finish");
                MetroFramework.MetroMessageBox.Show(this, "Add Product Master Finish", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (blnRet == false)
            {
                //MessageBox.Show("Error");
                MetroFramework.MetroMessageBox.Show(this, "Add Product Master Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_product_uom(string id)
        {
            using (db = new similanwms_nhkEntities())
            {
                var ds = (from c in db.product_uom where c.item_no == id select c).ToList();
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

        private void add_product_uom()
        {
            try
            {
                using (db = new similanwms_nhkEntities())
                {
                    var ds = (from c in db.product_uom where c.item_no == m_txt_item_no.Text select c).ToList();
                    if (ds.Count > 0)
                    {
                        m_lbl_pro_uom.BackColor = Color.Red;
                    }
                    else
                    {
                        for (int i = 0; i <= m_dgv.Rows.Count - 1; i++)
                        {
                            db.product_uom.Add(new product_uom()
                            {
                                client = "NHK",
                                item_no = m_txt_item_no.Text.Trim(),
                                item_packing = m_dgv.Rows[i].Cells[3].Value.ToString(),
                                item_uom = m_dgv.Rows[i].Cells[4].Value.ToString(),
                                item_qty = Convert.ToDecimal(m_dgv.Rows[i].Cells[5].Value.ToString()),
                                item_height = Convert.ToDecimal(m_dgv.Rows[i].Cells[6].Value.ToString()),
                                item_width = Convert.ToDecimal(m_dgv.Rows[i].Cells[7].Value.ToString()),
                                item_depth = Convert.ToDecimal(m_dgv.Rows[i].Cells[8].Value.ToString()),
                                item_volume = Convert.ToDecimal(m_dgv.Rows[i].Cells[9].Value.ToString()),
                                item_weight = Convert.ToDecimal(m_dgv.Rows[i].Cells[10].Value.ToString()),
                                uom_sequence = Convert.ToInt32(m_dgv.Rows[i].Cells[11].Value.ToString()),
                                create_date = DateTime.Now
                            });
                            db.SaveChanges();
                        }
                        m_lbl_pro_uom.BackColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                m_lbl_pro_uom.BackColor = Color.Yellow;
            }
        }

        private void add_product_uom_temp()
        {
            try
            {
                using (db = new similanwms_nhkEntities())
                {
                    var ds = (from c in db.product_uom_temp where c.item_no == m_txt_item_no.Text select c).ToList();
                    if (ds.Count > 0)
                    {
                        m_lbl_pro_uom_temp.BackColor = Color.Red;
                    }
                    else
                    {
                        for (int i = 0; i <= m_dgv.Rows.Count - 1; i++)
                        {
                            db.product_uom_temp.Add(new product_uom_temp()
                            {
                                client = "NHK",
                                item_no = m_txt_item_no.Text.Trim(),
                                item_packing = m_dgv.Rows[i].Cells[3].Value.ToString(),
                                item_uom = m_dgv.Rows[i].Cells[4].Value.ToString(),
                                item_qty = Convert.ToDecimal(m_dgv.Rows[i].Cells[5].Value.ToString()),
                                item_height = Convert.ToDecimal(m_dgv.Rows[i].Cells[6].Value.ToString()),
                                item_width = Convert.ToDecimal(m_dgv.Rows[i].Cells[7].Value.ToString()),
                                item_depth = Convert.ToDecimal(m_dgv.Rows[i].Cells[8].Value.ToString()),
                                item_volume = Convert.ToDecimal(m_dgv.Rows[i].Cells[9].Value.ToString()),
                                item_weight = Convert.ToDecimal(m_dgv.Rows[i].Cells[10].Value.ToString()),
                                uom_sequence = Convert.ToInt32(m_dgv.Rows[i].Cells[11].Value.ToString()),
                                create_date = DateTime.Now
                            });
                            db.SaveChanges();
                        }
                        m_lbl_pro_uom_temp.BackColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                m_lbl_pro_uom_temp.BackColor = Color.Yellow;
            }
        }

        private void add_product_zoning()
        {
            ooProduct_Master.p_item_no = m_txt_item_no.Text.Trim();
            bool blnRet = ooProduct_Master.add_product_zoning();
            if (blnRet == true)
            {
                m_lbl_zoning.BackColor = Color.Green;
            }
            else if(blnRet == false)
            {
                m_lbl_zoning.BackColor = Color.Red;
            }
        }

        private void add_product_barcode()
        {
            ooProduct_Master.p_item_no = m_txt_item_no.Text.Trim();
            bool blnRet = ooProduct_Master.add_product_barcode();
            if (blnRet == true)
            {
                m_lbl_pro_barcode.BackColor = Color.Green;
            }
            else if (blnRet == false)
            {
                m_lbl_pro_barcode.BackColor = Color.Red;
            }
        }

    }
}
