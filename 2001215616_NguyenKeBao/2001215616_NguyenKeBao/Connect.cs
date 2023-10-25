using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001215616_NguyenKeBao
{
    class Connect
    {
        public SqlConnection conn;
        public Connect()
        {
            conn = new SqlConnection("Data Source= A209PC06;Initial Catalog= QL_SinhVien;Integrated Security = true");

        }
        public Connect(string strcn)
        {
            conn = new SqlConnection(strcn);
        }

    }
}
