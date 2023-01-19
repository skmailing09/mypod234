<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Mail.aspx.vb" Inherits="SKMailing.Mail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Send Mail</title>
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

    <%--VALIDATION SCRIPT FOT EXCEL FILE--%>
    <script>
        function checkfile(sender) {
            debugger;
            var validExts = new Array(".xlsx", ".xls");
            var fileExt = sender.value;
            fileExt = fileExt.substring(fileExt.lastIndexOf('.'));
            if (validExts.indexOf(fileExt) < 0) {
                alert("Invalid file selected, valid files are of " +
                         validExts.toString() + " types.");
                return false;
            }
            else return true;
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <%-- ==================================Header Start===================================--%>
        <div id="header" class="header-size"></div>
        <%-- ==================================Header End===================================--%>

        <%-- ==================================Form Start===================================--%>

        <section class="section container ">
            <div class="row">
                <div class="col-md-12 section-title">
                    <h2>
                        <span class="section-name">
                            <span class="center-align">Bulk <span class="section-name-color">Mail</span> </span></span>
                    </h2>
                </div>
            </div>

            <div class="row main-container">
                <div class=" col-sm-9">
                    <div class="form">
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">To</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtTo" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6"></div>
                                <div class="col-sm-6">
                                    <div class="col-sm-6">
                                        <asp:FileUpload ID="rd_POD" runat="server" CssClass="btn-right" onchange="checkfile(this);" />
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:Button ID="btnEmailUpload" runat="server" Text="Upload File" CssClass=" " />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">Subject</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtSubject" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <%--<div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">Important</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtImportant" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>--%>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">Password</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <label class="lbl">Body</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtBody" runat="server" CssClass="form-control" placeholder="Enter Your State" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6"></div>
                                <div class="col-sm-6">
                                    <div class="col-sm-6">
                                        <asp:FileUpload ID="flAtch" runat="server" CssClass="btn-right" />
                                        <%--<asp:Button ID="btnAttacment" runat="server" Text="Upload File" CssClass=" " />--%>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:Button ID="btnSend" runat="server" Text="Send" CssClass="button" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </section>

        <%-- ==================================Form Start===================================--%>

        <%-- ==================================Footer Start===================================--%>
        <div id="footer"></div>
        <%-- ==================================Footer End===================================--%>
    </form>
</body>
</html>
