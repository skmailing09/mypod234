<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Doc_status.aspx.vb" Inherits="SKMailing.Doc_status" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>DOC Status</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!-- ==========================css============================-->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/custom.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link rel="icon" href="img/favicon.ico" />
    <!--==============Call Header & Footer===========================-->
    <script src="Script/jquery.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
    <script>
        $(function () {
            $("#header").load("header.html");
            $("#footer").load("footer.html");
        });

    </script>


</head>
<body>
    <%-- ==================================Header Start===================================--%>
    <div id="header" class="header-size"></div>
    <%-- ==================================Header End===================================--%>

    <%-- ==================================Form Start===================================--%>

    <form id="form1" runat="server">
        <section class="section container Yellow-BG">
            <div class="row">
                <div class="col-md-12 section-title">
                    <h2>
                        <span class="section-name">
                            <span class="center-align">DOC <span class="section-name-color">Status</span> </span></span>
                    </h2>
                </div>
            </div>

            <div class="row main-container">
                <div class=" col-sm-9">
                    <div class="form">
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">Tracking ID</label>
                                </div>
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <asp:TextBox ID="txtTrackId" runat="server" CssClass="form-control input-mrg " placeholder="Enter Your Tracking ID"></asp:TextBox>
                                        <asp:Button ID="btnSearchButton" runat="server" Text="Search" CssClass="btn-mrg doc_btn" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">Name</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtName" ReadOnly="true" runat="server" CssClass="form-control" placeholder="Enter Your Name"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">Address</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtAddress" runat="server" ReadOnly="true"
                                        CssClass="form-control" TextMode="MultiLine" placeholder="Enter Your Address"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">State</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtState" runat="server" ReadOnly="true"
                                        CssClass="form-control" placeholder="Enter Your State"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">Pin No.</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtPn" runat="server" ReadOnly="true"
                                        CssClass="form-control" placeholder="Enter your Pin No."></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-sm-6">
                                <label class="lbl">Status</label>
                            </div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtStatus" runat="server" ReadOnly="true"
                                    CssClass="form-control" placeholder="Enter Your Status"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </section>
    </form>
    <%-- ==================================Form Start===================================--%>

    <%-- ==================================Footer Start===================================--%>
    <div id="footer"></div>
    <%-- ==================================Footer End===================================--%>
</body>
</html>
