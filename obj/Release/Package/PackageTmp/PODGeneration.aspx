<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="~/PODGeneration.aspx.vb" Inherits="SKMailing.PODGeneration" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=7.2.13.1016, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>POD Generation</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!-- ==========================css============================-->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/custom.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />

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
                alert("Invalid file selected, valid files are of " + validExts.toString() + " types.");
                return false;
            }
            else return true;
        }
    </script>
     <script>
         function fnViewReport() {
             debugger;
             oWnd = $find("ReportViewer1")
             setTimeout(oWnd.show(), 500);
         }
    </script>
</head>
<body>
   <%-- <div class="se-pre-con"></div>--%>
    <%-- ==================================Header Start===================================--%>
    <div id="header" class="header-size"></div>
    <%-- ==================================Header End===================================--%>

    <%-- ==================================Form Start===================================--%>
    <form id="form1" runat="server">
        <section class="section Yellow-BG">
            <div class="row">
                <div class="col-md-12 section-title">
                    <h2>
                        <span class="section-name">
                            <span class="center-align">POD <span class="section-name-color">Status</span> </span></span>
                    </h2>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 pod-combo">
                    <telerik:RadComboBox ID="cmbcompany" runat="server">
                        
                                  <Items>
                                    <telerik:RadComboBoxItem Value="S K MAILING SERVICES" Text="S K MAILING SERVICES" />
                                 
                                    <telerik:RadComboBoxItem Value="S K EXPRESS" Text="S K EXPRESS" />

                                </Items>
                                    

                                
                    </telerik:RadComboBox>
                </div>
            </div>
            <div class="row main-container" id="container">
                <div class=" col-sm-12">
                    <div class="form">
                        <div class="form-group">
                            <div class="row">
                                <div class="col-sm-6">
                                    <asp:FileUpload ID="rd_POD" runat="server" CssClass="btn-right" onchange="checkfile(this);" />
                                </div>
                                <div class="col-sm-6">
                                    <asp:Button ID="btnupload" runat="server" Text="Upload File" />
                                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           <%-- <div class="row ">
                <div class="col-sm-12">
                    <div class="">
                        
                        <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="500px" ViewMode="PrintPreview" SkinID="Default" >
                       
                        </telerik:ReportViewer>
                    </div>
                </div>
            </div>--%>
        </section>

    </form>
    <%-- ==================================Form Start===================================--%>

    <%-- ==================================Footer Start===================================--%>
    <div id="footer"></div>
    <%-- ==================================Footer End===================================--%>
</body>
</html>
