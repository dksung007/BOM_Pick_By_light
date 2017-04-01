using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_BOM.UI;
using System.Windows.Forms;
using System.IO;
using Manage_BOM.Model;
using System.Data.SqlClient;

namespace Manage_BOM.Class
{
   public class cls_Common
    {
        private similanwms_nhkEntities db;
        private SqlConnectionStringBuilder builder;
        public UIProduct_Master p_UIProduct_Master = null;
        public UIBOM_Master p_UIBOM_Master = null;
        public UIShow_BOM_Master p_UIShow_BOM_Master = null;
        public UIShow_Product_Master p_UIShow_Product_Master = null;
        public string P_LOG_FILE_PATH = Application.StartupPath + "\\Log";
        public void writeLog(string message)
        {
            string strFile = string.Empty;
            string strPath = P_LOG_FILE_PATH + "\\" + DateTime.Now.ToString("yyyyMM");
            if (!Directory.Exists(strPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(strPath);
            }
            strFile = strPath + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            File.AppendAllText(strFile, DateTime.Now.ToString("yyyyMMddHHmmss") + " : " + message + Environment.NewLine);
        }

        public string ConnectionString()
        {
            string StrConn;
            using (db = new similanwms_nhkEntities())
            {
                builder = new SqlConnectionStringBuilder(db.Database.Connection.ConnectionString);
                StrConn = ("Data Source=" + builder.DataSource +
                       "\\SQLEXPRESS;Initial Catalog=" + builder.InitialCatalog +
                      ";Persist Security Info=True;User ID=" + builder.UserID +
                                                  ";Password=" + builder.Password);

                //StrConn = "data source =.\\sqlexpress; initial catalog = db_cf_ford; user id = sa; password = Passw0rd;";
            }
            return StrConn.ToString();
        }


    }


   
}
