using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WORK_TEST.Repositories;

namespace WORK_TEST
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FruitRepository fruitRepository = new FruitRepository();

            var data = fruitRepository.getFruits();

            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void btnNewEntry_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addfruit.aspx");
        }
    }
}