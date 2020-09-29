<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="IQCform.aspx.cs" Inherits="IQCform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width:80%;margin-top:30px;">
        <div class="row">
            <div class="col">
                <div class="card-body" aria-sort="none">
                    <div>
                        檢驗日期 : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        品名 : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        料號 : <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Class="btn btn-success" Text="搜尋" />
                    </div>
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="檢驗日期" DataFormatString="{0:d}" HeaderText="檢驗日期" SortExpression="檢驗日期" />
                            <asp:BoundField DataField="料號" HeaderText="料號" SortExpression="料號" />
                            <asp:BoundField DataField="品名" HeaderText="品名" SortExpression="品名" />
                            <asp:BoundField DataField="供應商名稱" HeaderText="供應商名稱" SortExpression="供應商名稱" />
                            <asp:BoundField DataField="進貨單號" HeaderText="進貨單號" SortExpression="進貨單號" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MOSAConnectionString %>"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
