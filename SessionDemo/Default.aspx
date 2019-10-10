<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Session/Cookie Demo</h1>
    </div>


    <div class="form-horizontal">
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtName"
                        CssClass="col-md-3 control-label">Name</asp:Label>
                    <div class="col-md-9">
                        <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtTeam"
                        CssClass="col-md-3 control-label">Team</asp:Label>
                    <div class="col-md-9">
                        <asp:TextBox runat="server" ID="txtTeam" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtDirection"
                        CssClass="col-md-3 control-label">Direction</asp:Label>
                    <div class="col-md-9">
                        <asp:TextBox runat="server" ID="txtDirection" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtDirection"
                        CssClass="col-md-3 control-label"></asp:Label>
                    <div class="col-md-9">
                        <asp:Button ID="BtnClear" runat="server"
                            Width="300"
                            Text="Clear Text Boxes"
                            OnClick="BtnClear_Click" />
                    </div>
                </div>


            </div>
            <div class="col-md-2">
                <h3>Session Vars</h3>
                <asp:Button ID="BtnSaveSessionVars" runat="server"
                    Width="100"
                    Text="Save"
                    OnClick="BtnSaveSessionVars_Click" />

                <asp:Button ID="BtnRetrieveSessionVars" runat="server"
                    Width="100"
                    Text="Retrieve"
                    OnClick="BtnRetrieveSessionVars_Click" />

                <asp:Button ID="BtnDeleteSessionVars" runat="server"
                    Width="100"
                    Text="Delete"
                    OnClick="BtnDeleteSessionVars_Click" />
            </div>

            <div class="col-md-2">
                <h3>Cookies</h3>
                <asp:Button ID="BtnSaveCookie" runat="server"
                    Width="100"
                    Text="Save"
                    OnClick="BtnSaveCookie_Click" />

                <asp:Button ID="BtnRetrieveCookie" runat="server"
                    Width="100"
                    Text="Retrieve"
                    OnClick="BtnRetrieveCookie_Click" />

                <asp:Button ID="BtnDeleteCookie" runat="server"
                    Width="100"
                    Text="Delete"
                    OnClick="BtnDeleteCookie_Click" />
            </div>

            <div class="col-md-2">
                <h3>Hybrid</h3>
                <asp:Button ID="BtnSaveHybrid" runat="server"
                    Width="100"
                    Text="Save"
                    OnClick="BtnSaveHybrid_Click" />

                <asp:Button ID="BtnRetrieveHybrid" runat="server"
                    Width="100"
                    Text="Retrieve"
                    OnClick="BtnRetrieveHybrid_Click" />

                <asp:Button ID="BtnDeleteHybrid" runat="server"
                    Width="100"
                    Text="Delete"
                    OnClick="BtnDeleteHybrid_Click" />
            </div>


        </div>
    </div>

</asp:Content>
