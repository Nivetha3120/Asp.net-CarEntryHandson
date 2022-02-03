using CarDetails.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarDetails
{
    public partial class CarInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            dbcon dc = new dbcon();
            dbprop dp = new dbprop();
            dp.CarModel = Cmode.Text;
            dp.Category = cate.Text;
            dp.Price = Convert.ToInt32( Pri.Text);
            dp.YearOfModel = Convert.ToInt32(yr.Text);
            dp.Description = desc.Text;
            string msg = dc.insert(dp);
            Response.Write($"<script>alert('{msg}')</script>");
            load();   
        }
        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            dbcon dc = new dbcon();
            dbprop dp = new dbprop();
             dp.CarModel = Cmode.Text;
            string msg = dc.delete(dp);
            Response.Write($"<script>alert('{msg}')</script>");
            load();

        }     
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            dbcon dc = new dbcon();
            dbprop dp = new dbprop();
            dp.CarModel = Cmode.Text;
            dp.Category = cate.Text;
            dp.Price = Convert.ToInt32(Pri.Text);
            dp.YearOfModel = Convert.ToInt32(yr.Text);
            dp.Description = desc.Text;
            string msg = dc.update(dp);
            Response.Write($"<script>alert('{msg}')</script>");
            load();
        }


        protected void load()
        {
            dbcon dc = new dbcon();
            DataTable dt = dc.Loaddb();
            GView.DataSource = dt;
            GView.DataBind();
        }

        protected void ResetBtn_Click(object sender, EventArgs e)
        {
            Cmode.Text = "";
            cate.Text = "";
            Pri.Text = "";
            yr.Text = "";
            desc.Text = "";
        }
    }
}