using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_BOM.Class;

namespace Manage_BOM.Class
{
    public class cls_Base
    {
        //public string strConn = "Data Source=10.101.1.30\\sqlexpress;Initial Catalog=similanwms_nhk_dev1;Persist Security Info=True;User ID=sa;Password=warehousedbo";
        //public string strConn = "Data Source=10.101.1.30\\sqlexpress;Initial Catalog=similanwms_nhk;Persist Security Info=True;User ID=sa;Password=warehousedbo";

        public static cls_Common ooCommon = new cls_Common();
        public static string dbConn = ooCommon.ConnectionString();
    }
}
