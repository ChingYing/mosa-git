using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //如果沒有登入 轉回登入頁面
        if (Session["admin"] == null)
        {
            Response.Redirect("login.aspx");
        }
        user admin = (user)Session["admin"];
        Labuser.Text = admin.姓名;

    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("login.aspx");
    }
}
