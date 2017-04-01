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
    public class cls_bom_details : cls_Base
    {
        private similanwms_nhkEntities db;
        private DataTable dt;
        private SqlConnection Conn;
        private SqlDataAdapter da;
        private StringBuilder sb = new StringBuilder();
        private SqlCommand Com;

        public string p_bom_id { get; set; }
        public string p_client { get; set; }
        public string p_setcode { get; set; }
        public string p_version { get; set; }
        public string p_item_no { get; set; }
        public string p_uom { get; set; }
        public string p_qty { get; set; }
        public string p_unit_cost { get; set; }
        public string p_total_cost { get; set; }
        public string p_maker { get; set; }
        public string p_last_update { get; set; }
        public string p_create_by { get; set; }
        public string p_create_date { get; set; }

        public int last_id()
        {
            int _id = 0;
            using (db = new similanwms_nhkEntities())
            {
                //var ds = (from c in db.product_master select c).Max();
                var ds = db.bom_detail.Max(u => (int?)u.row_id) ?? 0;
                _id = ds;
            }
            return _id;
        }

        public DataTable show_bom_details()
        {
            dt = new DataTable();
            sb.Remove(0, sb.Length);
            sb.Append("SELECT client, setcode, version, item_no, uom, qty, unit_cost, total_cost,");
            sb.Append("maker, last_update, created_by, created_date, row_id ");
            sb.Append("FROM bom_detail where setcode ='" + p_bom_id + "'");
            string strSQL = sb.ToString();
            using (Conn = new SqlConnection(dbConn))
            {
                da = new SqlDataAdapter(strSQL, Conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool add_bom_detials(DataTable dt)
        {
            bool blnRet = false;
            try
            {
                sb.Remove(0, sb.Length);
                sb.Append("");
                string strSQL = sb.ToString();
                using (Conn = new SqlConnection(dbConn))
                {
                    Conn.Open();
                    Com = new SqlCommand(strSQL, Conn);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Com.Parameters.Add("@", SqlDbType.VarChar).Value = dt.Rows[i][0].ToString();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return blnRet;
        }

        public bool delete_bom_details(string id)
        {
            bool blnRet = false;
            try
            {
                using (db = new similanwms_nhkEntities())
                {
                    var ds = (from c in db.bom_detail where c.setcode == id select c).ToList();
                    if (ds.Count > 0)
                    {
                        for (int i = 0; i < ds.Count; i++)
                        {
                            db.bom_detail.Remove(ds[i]);
                            db.SaveChanges();
                        }
                         
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
