using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    MOSAEntities db = new MOSAEntities();
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        string id, pwd, identity, supplier;

        id = userid.Text;
        pwd = password.Text;
        //是否有找到帳號
        var admin = db.user.Where(m => m.帳號 == id && m.密碼 == pwd).FirstOrDefault();
        if (admin == null)
        {
            labelshow.Text = "查無此帳號";
            return;
        }
        Session["admin"] = admin;
        identity = admin.權限;
        supplier = admin.姓名;

        Response.Redirect("IQCform.aspx");
    }
}