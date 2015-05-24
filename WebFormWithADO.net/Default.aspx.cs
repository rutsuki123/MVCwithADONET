using MVCwithADO.NET.Models.DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormWithADO.net
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductDal p = new ProductDal();
            IEnumerable<DataRow> table = p.Get();
            var test = new List<object>();
            foreach (var item in table)
            {
                foreach (var item2 in item.ItemArray)
                {
                    Response.Write(item2 + "<br>");
                }
                Response.Write("<br>");
            }
            
        }
    }
}