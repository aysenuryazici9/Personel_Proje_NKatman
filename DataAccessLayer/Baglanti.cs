using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=LAPTOP-CVNIP36M\MSSQL;Initial Catalog=Db_NKatman_Personel_Udemy;Integrated Security=True");
    }
}
