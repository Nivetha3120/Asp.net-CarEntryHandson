<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarInfo.aspx.cs" Inherits="CarDetails.CarInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        h1{
            margin-left:300px;
        }
        form{
            
             margin-left:300px;
        }
        button
        {
            padding:3px;
           
        }
    </style>
</head>
<body>
    <h1>Car Details</h1>
    <form id="form1" runat="server">
       <div>
         
       <table>   
           <tr>
                  <td>  <asp:Label ID="Label1" runat="server" Text="CarModel"></asp:Label>  </td>
                  <td>:</td>
                  <td> <asp:TextBox ID="Cmode" runat="server"></asp:TextBox> </td>
           </tr>
           <tr>
                   <td> <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label> </td>
                    <td>:</td>
                  <td>  <asp:TextBox ID="cate" runat="server"></asp:TextBox></td>
          </tr>
          <tr>         
                   <td> <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label> </td>
                   <td>:</td>
                   <td> <asp:TextBox ID="Pri" runat="server"></asp:TextBox></td>
         </tr> 
       <tr>
            <td> <asp:Label ID="Label4" runat="server" Text="Model Year"></asp:Label> </td>
            <td>:</td>
            <td> <asp:TextBox ID="yr" runat="server"></asp:TextBox></td>
       </tr>
       <tr>
            <td> <asp:Label ID="Label5" runat="server" Text="Description"></asp:Label> </td>
            <td>:</td>
            <td> <asp:TextBox ID="desc" runat="server"></asp:TextBox></td>       
       </tr>
        </table>
           <br />
           <asp:Button ID="InsertBtn" CssClass="bg-primary" runat="server" Text="Submit" OnClick="InsertBtn_Click" />
           <asp:Button ID="UpdateBtn" CssClass="bg-primary" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
           <asp:Button ID="ResetBtn" CssClass="bg-primary"  runat="server" Text="Reset" OnClick="ResetBtn_Click" />
           <asp:Button ID="DeleteBtn" CssClass="bg-primary" runat="server" Text="Delete" OnClick="DeleteBtn_Click" />
           </div>
        <br />
        <br />
        
        <div>
            <asp:GridView ID="GView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>

