<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ContactUs.aspx.vb" Inherits="SKMailing.ContactUs" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <title>Contaact US</title>
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
        $(function () { $("#header").load("header.html"); $("#footer").load("footer.html") })
    </script>
</head>
<body>
    <div id="header" class="header-size"></div>
    <form id="form1" runat="server">
        <section class="Yellow-BG">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 section-title">
                        <h2>
                            <span class="section-name">
                                <span class="center-align">Contact <span class="section-name-color">US</span> </span></span>
                        </h2>
                    </div>
                </div>
                <div class="row main-container">
                    <div class="col-md-6 col-sm-offset-3 ">
                        <div class="form">
                            <div class="form-group">
                                <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Your Name"></asp:TextBox>
                                <div class="validation"></div>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Your Email"></asp:TextBox>
                                <div class="validation"></div>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtSubject" runat="server" class="form-control" placeholder="Subject"></asp:TextBox>
                                <div class="validation"></div>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtMessage" runat="server" class="form-control" placeholder="Please write something for us"></asp:TextBox>
                                <div class="validation"></div>
                            </div>
                            <div class="text-center btn-position">
                                <asp:Button ID="btnSubmit" runat="server" Text="Send Message" />
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblmessage" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row" style="margin-top: 40px;">
                    <div class="col-lg-12">
                        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3770.2572654761825!2d72.89265911437712!3d19.09636655629558!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3be7c879bbc2e449%3A0x7cf0d58f96ffca96!2sS.K%20Mailing%20Services!5e0!3m2!1sen!2sin!4v1581591732260!5m2!1sen!2sin" width="100%" height="400px" frameborder="0" style="border: 0;" allowfullscreen=""></iframe>
                    </div>
                </div>

            </div>
        </section>
    </form>
    <%-- ==================================Contact Section End===================================--%>

    <%-- ==================================Footer Start===================================--%>
    <div id="footer"></div>
    <%-- ==================================Footer End===================================--%>
</body>
</html>
