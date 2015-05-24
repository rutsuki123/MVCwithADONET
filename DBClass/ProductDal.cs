using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MVCwithADO.NET.Models.DALs
{
    public class ProductDal
    {
        public EnumerableRowCollection<DataRow> Get()
        {
            string ConnectionStrings = "data source=.\\sqlexpress;initial catalog=Northwind;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection conn = new SqlConnection(ConnectionStrings);
            string sql = "select * from Products";
            DataSet ds = new DataSet();
            using (conn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "Products");
            }
            EnumerableRowCollection<DataRow> table = ds.Tables[0].AsEnumerable();
            return table;
        }
    }
}