<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Client.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 1200px;
            height: 630px;
            background-color:darkgray
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <h2>A Online tool for fishing in the Capital region</h2>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Which Province Fishing ticket do you have? "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="OnCBox" runat="server" AutoPostBack="True" OnCheckedChanged="OnCBox_CheckedChanged" Text="Ontario" />
        <asp:CheckBox ID="QcCBox" runat="server" AutoPostBack="True" OnCheckedChanged="OnCBox_CheckedChanged" Text="Quebec" />
        <asp:Label ID="provincewarning" runat="server" ForeColor="#CC0000"></asp:Label>
        <br />
        <asp:Image ID="provinceImg1" runat="server" Height="200px" />
        <asp:Image ID="provinceImg2" runat="server" Height="200px" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Select Which Fishing Zone you plan to go: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ZoneDrp" runat="server">
        </asp:DropDownList>
        <asp:Label ID="zonewarning" runat="server" ForeColor="#CC0000"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Select which fish you plan to catch: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="speciesDrp" runat="server" Height="25px" Width="131px" OnSelectedIndexChanged="speciesDrp_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <asp:Label ID="specieswarning" runat="server" ForeColor="#CC0000"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <br />
        <asp:Image ID="fishImg" runat="server" Height="200px" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Select which date you plan to go if available: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="catchCalendar" runat="server"></asp:Calendar>
&nbsp;&nbsp;&nbsp;
        <div style="margin-left: 80px">
            <asp:Button ID="Inquerybtn" runat="server" OnClick="Inquerybtn_Click" Text="Inquery" />
        </div>
        <br />
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        <br />
        <br />
        Number Limit:&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label5" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        Length Limit:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
    <p>
        <img alt="" class="auto-style2" src="aerial.jpg" /></p>
</body>
</html>
