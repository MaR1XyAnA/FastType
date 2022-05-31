using Keybord_Trening.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keybord_Trening.AppData
{
    class ConnectDb
    {
        private static FastType_Mironow_VolkovEntities context; 

        public static FastType_Mironow_VolkovEntities GetContext()
        {
            if (context == null)
            {
                context = new FastType_Mironow_VolkovEntities();
            }
            return context;
        }
    }
}


//metadata=res://*/Model.Model1.csdl|res://*/Model.Model1.ssdl|res://*/Model.Model1.msl;provider=System.Data.SqlClient;provider connection string="data source=SQL;initial catalog=FastType_Mironow_Volkov;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
