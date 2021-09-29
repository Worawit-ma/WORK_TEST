using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WORK_TEST.Repositories;

namespace WORK_TEST
{
    public partial class Addfruit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



    

        protected void btnAddData_Click(object sender, EventArgs e)
        {
            FruitRepository fruitRepository = new FruitRepository();

            fruitRepository.addFruits(TextBox1.Text, TextBox2.Text);


          //  Response.Write("T1 : "+ TextBox1.Text+"   T2 : "+ TextBox2.Text);




        }

        protected void btnBackHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}