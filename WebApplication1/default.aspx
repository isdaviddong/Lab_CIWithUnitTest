<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>範例</title>
      <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
      <div class="row" style="margin: 12px">
            <div class="col-lg-12">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        範例 : 
                    </div>
                    <div class="panel-body">
                        <label>身高:</label>
                        <asp:TextBox ID="TextBoxHeight" CssClass="form-control" runat="server"></asp:TextBox>
                        <label>體重:</label>
                        <asp:TextBox ID="TextBoxWeight" CssClass="form-control" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="Button2" CssClass="btn btn-primary"  runat="server" Text="計算" OnClick="Button2_Click" />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>  
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
