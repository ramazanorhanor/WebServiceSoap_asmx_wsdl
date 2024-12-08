<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServisJavaScript.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript">
        debugger;
        function GetStudentById() {
            debugger;
            var id = document.getElementById("txtStudentId").value;
            WebServisJavaScript.StudentService.GetStudentById(id, GetStudentByIdSuccessCallback, GetStudentByIdFaiedCallback);
        }
        function GetStudentByIdSuccessCallback(results) {
            debugger;
            document.getElementById("txtName").value = results["Name"];
            document.getElementById("txtGender").value = results["Gender"];
            document.getElementById("txtTotalMarks").value = results["TotalMarks"];
        }
        function GetStudentByIdFaiedCallback(failed) {
            debugger;
            alert(failed.get_message())
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/StudentService.asmx" />
            </Services>
        </asp:ScriptManager>
        <%--<asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>--%>

        <table style="font-family: Arial; border: 1px solid black">
            <tr>
                <td><b>ID</b></td>
                <td>
                    <asp:TextBox ID="txtStudentId" runat="server"> </asp:TextBox>
                    <%-- <asp:Button ID="Button1" runat="server" Text="Button" />--%>
                    <input id="Button1" type="button" value="Get Students" onclick="GetStudentById()" />
                </td>
            </tr>

            <tr>
                <td><b>Name</b></td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"> </asp:TextBox></td>
            </tr>
            <tr>
                <td><b>Gender</b></td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"> </asp:TextBox></td>
            </tr>
            <tr>
                <td><b>Total Marks</b></td>
                <td>
                    <asp:TextBox ID="txtTotalMarks" runat="server"> </asp:TextBox></td>
            </tr>
        </table>
        <h1> butona her bastığımda kısmi bir post-back gerçekleşir Sayfanın tamamı gidip gelmez</h1>
        <asp:Label ID="lblTime" runat="server" ></asp:Label>
    </form>
</body>
</html>
