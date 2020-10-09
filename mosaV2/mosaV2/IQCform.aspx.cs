using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class IQCform : System.Web.UI.Page
{
    MOSAEntities db = new MOSAEntities();
    string name, identity, query;
    protected void Page_Load(object sender, EventArgs e)
    {
        user admin = (user)Session["admin"];
        //如果沒有登入 轉回登入頁面
        if (Session["admin"] == null)
        {
            Response.Redirect("login.aspx");
        }
        identity = admin.權限;
        name = admin.姓名;
        if (!IsPostBack)
        {
            if (identity == "供應商")
            {
                query = "SELECT DISTINCT TOP (10) 檢驗日期, 料號, 品名, 供應商名稱, 進貨單號 FROM IQC where 供應商名稱='" + name + "' ORDER BY 檢驗日期 DESC";
                SqlDataSource1.SelectCommand = query;
                //SqlDataSource1.ConnectionString = "Data Source=120.113.70.220,1433;Initial Catalog=MOSA;User ID=nfu;Password=nfu123@@@;MultipleActiveResultSets=True;Application Name=EntityFramework";
            }
            else
            {
                query = "SELECT DISTINCT TOP (10) 檢驗日期, 料號, 品名, 供應商名稱, 進貨單號 FROM IQC ORDER BY 檢驗日期 DESC";
                SqlDataSource1.SelectCommand = query;
                //SqlDataSource1.ConnectionString = "Data Source=120.113.70.220,1433;Initial Catalog=MOSA;User ID=nfu;Password=nfu123@@@;MultipleActiveResultSets=True;Application Name=EntityFramework";
            }
            GridView1.DataSourceID = "SqlDataSource1";
            GridView1.DataBind();
        }
    }

    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        string dateStart, dateEnd,item,itemText;
        dateStart = Start.Text; //起始日期
        dateEnd = End.Text;     //結束日期
        item = itemDrop.SelectedValue;
        itemText = itemValue.Text;
        user admin = (user)Session["admin"];
        identity = admin.權限;
        name = admin.姓名;
        if (Start.Text == "" | End.Text == "") Label1.Text = "日期未填寫!";
        else
        {
            Label1.Text = "";
            if (identity == "供應商")
            {
                query = "SELECT DISTINCT 檢驗日期, 料號, 品名, 供應商名稱, 進貨單號 FROM IQC where 供應商名稱='" + name + "' and 檢驗日期 between '" + dateStart + "' and '" + dateEnd + "' and " + item + "='" + itemText +"'";
                SqlDataSource1.SelectCommand = query;
            }
            else
            {
                query = "SELECT DISTINCT 檢驗日期, 料號, 品名, 供應商名稱, 進貨單號 FROM IQC where 檢驗日期 between '" + dateStart + "' and '" + dateEnd + "' and " + item + "='" + itemText + "'";
                SqlDataSource1.SelectCommand = query;
            }
            GridView1.DataSourceID = "SqlDataSource1";
            GridView1.DataBind();
        }
    }
}