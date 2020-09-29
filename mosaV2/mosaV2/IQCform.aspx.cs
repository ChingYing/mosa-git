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
    protected void Page_Load(object sender, EventArgs e)
    {
        string name, identity, query;
        user admin = (user)Session["admin"];
        identity = admin.權限;
        name = admin.姓名;
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