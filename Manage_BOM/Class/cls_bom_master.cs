using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Manage_BOM.Model;

namespace Manage_BOM.Class
{
    public class cls_bom_master : cls_Base
    {
        private similanwms_nhkEntities db;
        private DataTable dt;
        private StringBuilder sb = new StringBuilder();
        private SqlConnection Conn;
        private SqlDataAdapter da;
        private SqlCommand Com;

        public string p_client { get; set; }
        public string p_setcode { get; set; }
        public string p_description { get; set; }
        public string p_version { get; set; }
        public string p_status { get; set; }
        public string p_currency { get; set; }
        public string p_standard_cost { get; set; }
        public string p_maker { get; set; }
        public string p_last_update { get; set; }
        public string p_create_by { get; set; }

        public DataTable show_product_master()
        {
            //            SELECT TOP (1000) row_id, client, item_no, product_class, description, pick_seq, default_grade, status, auto_zoning, bonded_flag, batch_no, lot_no, expiry_dt, production_dt, item_size, item_color, item_class,
            //                         weight_required, dimensions, serial_no, supplier, owner, country_origin, nonstandard_pack, remarks, create_by, create_date, maker, last_update, min_pick_face, max_pick_face, Primary_Risk, min_qty, max_qty,
            //                          replenish_uom, n_code
            //FROM            product_master
            dt = new DataTable();
            sb.Remove(0, sb.Length);
            sb.Append("SELECT client, item_no, product_class, description, pick_seq, default_grade, status, auto_zoning, ");
            sb.Append("bonded_flag, batch_no, lot_no, expiry_dt, production_dt, item_size, item_color, item_class,");
            sb.Append(" weight_required, dimensions, serial_no, supplier, owner, country_origin, nonstandard_pack, remarks, ");
            sb.Append("create_by, create_date, maker, last_update, min_pick_face, max_pick_face, Primary_Risk, min_qty, max_qty,replenish_uom, n_code ");
            sb.Append("FROM product_master");

            string strSQL = sb.ToString();
            using (Conn = new SqlConnection(dbConn))
            {
                da = new SqlDataAdapter(strSQL, Conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable show_bom_master()
        {
            dt = new DataTable();
            sb.Remove(0, sb.Length);
            sb.Append("SELECT client, setcode, description, version, status, currency, standard_cost, maker, last_update, created_by, created_date ");
            sb.Append("FROM bom_master order by setcode");
            String strSQL = sb.ToString();
            using (Conn = new SqlConnection(dbConn))
            {
                da = new SqlDataAdapter(strSQL, Conn);
                da.Fill(dt);
            }

            return dt;
        }

        public bool add_bom_master()
        {
            bool blnRet = false;
            try
            {
                //sb.Remove(0, sb.Length);
                //sb.Append("insert into bom_master (client, setcode, description, version, status,");
                //sb.Append("currency, standard_cost, maker, last_update, created_by, created_date) ");
                //sb.Append("VALUES (@client, @setcode, @description, @version, @status,");
                //sb.Append("@currency, @standard_cost, @maker, @last_update, @created_by, @created_date)");
                //string strSQL = sb.ToString();
                //using (Conn = new SqlConnection(strConn))
                //{
                //    Conn.Open();
                //    Com = new SqlCommand(strSQL, Conn);
                //    Com.Parameters.Add("@client", SqlDbType.NVarChar).Value = p_clinet;
                //    Com.Parameters.Add("@setcode", SqlDbType.NVarChar).Value = p_setcode;
                //    Com.Parameters.Add("@description", SqlDbType.NVarChar).Value = p_description;
                //    Com.Parameters.Add("@version", SqlDbType.NVarChar).Value = p_version;
                //    Com.Parameters.Add("@status", SqlDbType.NVarChar).Value = p_status;
                //    Com.Parameters.Add("@currency", SqlDbType.NVarChar).Value = p_currency;
                //    Com.Parameters.Add("@standard_cost", SqlDbType.Decimal).Value = p_standard_cost;
                //    Com.Parameters.Add("@maker", SqlDbType.NVarChar).Value = p_maker;
                //    Com.Parameters.Add("@last_update", SqlDbType.NVarChar).Value = p_last_update;
                //    Com.Parameters.Add("@created_by", SqlDbType.NVarChar).Value = p_create_by;
                //    Com.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                //    if (Com.ExecuteNonQuery() > 0)
                //    {
                //        blnRet = true;
                //    }
                //    else
                //    {
                //        blnRet = false;
                    //}

                //}


                using (db = new similanwms_nhkEntities())
                {
                    var ds = (from c in db.bom_master where c.setcode == p_setcode select c).FirstOrDefault();
                    if (ds != null)
                    {
                        blnRet = false;
                    }
                    else
                    {
                        db.bom_master.Add(new bom_master()
                        {
                            client = p_client , setcode = p_setcode , description = p_description , version = p_version , currency = p_currency,
                            status = p_status , standard_cost = Convert.ToDecimal(p_standard_cost) , maker = p_maker ,
                            last_update = p_last_update , created_by = p_create_by , created_date = DateTime.Now
                    });
                        db.SaveChanges();
                        blnRet = true;
                    }
                }

            }
            catch (Exception)
            {
                blnRet = false;
            }
            return blnRet;
        }

        public DataTable show_by_id(string id)
        {
            dt = new DataTable();
            sb.Remove(0, sb.Length);
            sb.Append("SELECT client, setcode, description, version, status, currency, standard_cost, maker, last_update, created_by, created_date ");
            sb.Append("FROM bom_master where setcode ='" + id + "'");
            string strSQL = sb.ToString();
            using (Conn = new SqlConnection(dbConn))
            {
                da = new SqlDataAdapter(strSQL, Conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool delete_bom_master(string id)
        {
            bool blnRet = false;
            try
            {
              using (db = new similanwms_nhkEntities())
                {
                    var ds = (from c in db.bom_master where c.setcode == id select c).FirstOrDefault();
                    if (ds != null)
                    {        
                        db.bom_master.Remove(ds);
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
