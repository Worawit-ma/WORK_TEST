<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addfruit.aspx.cs" Inherits="WORK_TEST.Addfruit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .myDiv {      
      text-align: center;
      text-align:center;
    }

    .button {
        border-bottom-right-radius;
     }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="myDiv">
            <h1> Add fruit Page</h1>       
        </div>
 
        <div class ="myDiv">
           <table>
               <tr>
                   <td>Name furit: </td>
                   <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> </td>
               </tr>
               <tr>
                   <td>Photo furit: </td>
                   <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> </td>
               </tr>
           </table>         
        </div>

        <div>
            <table>
                    <td> <asp:Button ID="Button1" runat="server" Text="Add" Click="btnAddData_Click" OnClick="btnAddData_Click"/></td>
                    <td> <asp:Button ID="Button2" runat="server" Text="Cancel" Click="btnBackHome_Click" OnClick="btnBackHome_Click"/></td>
            </table>
        </div>


    </form>
</body>
</html>
