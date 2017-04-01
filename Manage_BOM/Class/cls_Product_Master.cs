using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_BOM.Model;
using System.Data;
using System.Data.SqlClient;

namespace Manage_BOM.Class
{

    public class cls_Product_Master : cls_Base
    {

        private similanwms_nhkEntities db;
        //private cls_Common ooCommon = new cls_Common();
        private DataTable dt;
        private StringBuilder sb = new StringBuilder();
        private SqlConnection Conn;
        private SqlDataAdapter da;
        private SqlCommand Com;

        public int p_rows_id { get; set; }
        public string p_client { get; set; }
        public string p_item_no { get; set; }
        public string p_product_class { get; set; }
        public string p_desription { get; set; }
        public string p_pick_seq { get; set; }
        public string p_defult_grade { get; set; }
        public string p_status { get; set; }
        public string p_auto_zoning { get; set; }
        public string p_bonded_flag { get; set; }
        public string p_batch_no { get; set; }
        public string p_lot_no { get; set; }
        public string p_expiry_dt { get; set; }
        public string p_production_dt { get; set; }
        public string p_item_size { get; set; }
        public string p_item_color { get; set; }
        public string p_item_class { get; set; }
        public string p_weight_required { get; set; }
        public string p_dimensions { get; set; }
        public string p_serail_no { get; set; }
        public string p_supplier { get; set; }
        public string p_owner { get; set; }
        public string p_country_origin { get; set; }
        public string p_nonstandard_pack { get; set; }
        public string p_remarks { get; set; }
        public string p_create_by { get; set; }
        public DateTime p_create_date { get; set; }
        public string p_maker { get; set; }
        public DateTime p_last_update { get; set; }
        public decimal p_min_pick_face { get; set; }
        public decimal p_max_pick_face { get; set; }
        public string p_Primary_Risk { get; set; }
        public decimal p_min_qty { get; set; }
        public decimal p_max_qty { get; set; }
        public string p_replenish_uom { get; set; }
        public string p_n_code { get; set; }

        public int auto_id()
        {
            int _id = 0;
            using (db = new similanwms_nhkEntities())
            {
                //var ds = (from c in db.product_master select c).Max();
                var ds = db.product_master.Max(u => (int?)u.row_id) ?? 0;
                _id = ds;
            }
            return _id;
        }

        public bool add_product_master()
        {
            bool blnRet = false;
            try
            {
                using (db = new similanwms_nhkEntities())
                {
                    var ds = (from c in db.product_master where c.item_no == p_item_no select c).FirstOrDefault();
                    if (ds != null)
                    {
                        blnRet = false;
                    }
                    else
                    {
                        db.product_master.Add(new product_master()
                        {

                            client = p_client,
                            item_no = p_item_no,
                            product_class = p_product_class,
                            description = p_desription,
                            pick_seq = p_pick_seq,
                            default_grade = p_defult_grade,
                            status = p_status,
                            auto_zoning = p_auto_zoning,
                            bonded_flag = p_bonded_flag,
                            batch_no = p_batch_no,
                            lot_no = p_lot_no,
                            expiry_dt = p_expiry_dt,
                            production_dt = p_production_dt,
                            item_size = p_item_size,
                            item_color = p_item_color,
                            item_class = p_item_class,
                            weight_required = p_weight_required,
                            dimensions = p_dimensions,
                            serial_no = p_serail_no,
                            supplier = p_supplier,
                            owner = p_owner,
                            country_origin = p_country_origin,
                            nonstandard_pack = p_nonstandard_pack,
                            remarks = p_remarks,
                            create_by = p_create_by,
                            create_date = p_create_date,
                            last_update = p_last_update,
                            min_pick_face = p_min_pick_face,
                            max_pick_face = p_max_pick_face,
                            Primary_Risk = p_Primary_Risk,
                            min_qty = p_min_qty,
                            max_qty = p_max_qty,
                            replenish_uom = p_replenish_uom,
                            n_code = p_n_code
                        });
                        db.SaveChanges();
                        blnRet = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ooCommon.writeLog(ex.Message);
                blnRet = false;

            }
            return blnRet;
        }

        public bool add_product_zoning()
        {
            bool blnRet = false;
            try
            {
                // query
            }
            catch (Exception)
            {
                blnRet = false;
            }
            return blnRet;
        }

        public bool add_product_barcode()
        {
            bool blnRet = false;
            try
            {
                sb.Remove(0, sb.Length);
                sb.Append("insert into  product_barcode (client, barcode_no, item_no, pack_uom, base_uom, convert_qty, last_update, maker, remark) ");
                sb.Append("values (@client, @barcode_no, @item_no, @pack_uom, @base_uom, @convert_qty, @last_update, @maker, @remark)");
                string strSQL = sb.ToString();
                using (Conn = new SqlConnection(dbConn))
                {
                    Conn.Open();
                    Com = new SqlCommand(strSQL, Conn);
                    Com.Parameters.Add("@client", SqlDbType.VarChar).Value = "NHK";
                    Com.Parameters.Add("@barcode_no", SqlDbType.VarChar).Value = p_item_no;
                    Com.Parameters.Add("@item_no", SqlDbType.VarChar).Value = p_item_no;
                    Com.Parameters.Add("@pack_uom", SqlDbType.VarChar).Value = string.Empty;
                    Com.Parameters.Add("@base_uom", SqlDbType.VarChar).Value = "PCS";
                    Com.Parameters.Add("@convert_qty", SqlDbType.Float).Value = 1.0000;
                    Com.Parameters.Add("@last_update", SqlDbType.DateTime).Value = DateTime.Now;
                    Com.Parameters.Add("@maker", SqlDbType.VarChar).Value = "dksung";
                    Com.Parameters.Add("@remark", SqlDbType.VarChar).Value = "Copy BOM";
                    if (Com.ExecuteNonQuery() > 0)
                    {
                        blnRet = true;
                    }
                    else
                    {
                        blnRet = false;
                    }
                }
            }
            catch (Exception)
            {
                blnRet = false;
            }
            return blnRet;
        }

        public bool add_zoning()
        {
            bool blnRet = false;
            try
            {
                sb.Remove(0, sb.Length);
                sb.Append("insert into product_zoning (client, item_no, zone, search_seq)");
                sb.Append("values (@client, @item_no, @zone, @search_seq)");
                string strSQL = sb.ToString();
                using(Conn = new SqlConnection(dbConn))
                {
                    Conn.Open();
                    Com = new SqlCommand(strSQL, Conn);
                    Com.Parameters.Add("@client", SqlDbType.VarChar).Value = "NHK";
                    Com.Parameters.Add("@item_no", SqlDbType.VarChar).Value = p_item_no;
                    Com.Parameters.Add("@zone", SqlDbType.VarChar).Value = "PICKFACE";
                    Com.Parameters.Add("@search_seq", SqlDbType.Int).Value = 1;
                    if (Com.ExecuteNonQuery() > 0)
                    {
                        blnRet = true;
                    }
                    else
                    {
                        blnRet = false;
                    }
                }
            }
            catch (Exception)
            {
                blnRet = false;
            }
            return blnRet;
        }

        public bool delete_product_master(int id)
        {
            bool blnRet = false;
            try
            {
                using (db = new similanwms_nhkEntities())
                {
                    var ds = (from c in db.product_master where c.row_id == id select c).FirstOrDefault();
                    if (ds != null)
                    {
                        db.product_master.Remove(ds);
                        db.SaveChanges();
                        blnRet = true;
                    }
                    else
                    {
                        blnRet = false;
                    }
                }
            }
            catch (Exception)
            {
                blnRet = false;
            }
            return blnRet;
        }
    }
}
