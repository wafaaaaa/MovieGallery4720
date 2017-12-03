<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Film.aspx.cs" Inherits="Film" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add a Movie</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h1>Add a movie to your Movie Gallery</h1>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Movie ID:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="FilmID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Movie Title:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="FilmName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Movie Description:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="FilmDesc" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Movie Release Date:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="FilmReleaseDate" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="Label5" runat="server" Text="Movie Rating:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="CertificationID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Movie Genre:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="FilmGenreID" runat="server"></asp:TextBox>
            <br />
        </div>
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" Text="Add Movie" OnClick="Button1_Click" />
        &nbsp;</p>
        <div>
            <table border="1">
                <tr>
                    <td>Movie ID: </td>
                    <td>Movie Title: </td>
                    <td>Movie Description: </td>
                    <td>Movie Release Date: </td>
                    <td>Movie Rating: </td>
                    <td>Movie Genre: </td>
                </tr>
                <tr>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>