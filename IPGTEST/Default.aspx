<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IPGTEST.Default" %>

<!DOCTYPE html lang="fa">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta name="viewport" content="width=device-width, initial-scale=1.0" charset="UTF-8">
    <style type="text/css">
        body {
            direction: rtl;
            font-family: Tahoma;
            font-size: 13px;
            color: gray;
        }

        #outPopUp {
            width: 49%;
            display: inline-block;
            vertical-align: top;
        }

        input {
            font-family: Tahoma;
            font-size: 11px;
            color: gray;
            width: 200px;
        }

        label {
            width: 100px;
            display: inline-block;
        }
    </style>
    <title></title>

</head>
<body>
    <table>
        <tr>
            <td style="vertical-align: top;">

                <%--________________________________________________________پرداخت____________________________________________________________--%>

                <form method="post" action="https://sepehr.shaparak.ir:8080/payment/pay">
                    <fieldset>
                        <legend>پرداخت </legend>
                        <div>
                            <label>TerminalID:</label>
                            <input type="text" name="TerminalID" value="" placeholder="شماره ترمینال" />
                        </div>
<%--                        <div>
                            <label>Amount:</label>
                            <input type="text" name="Amount" value="" placeholder="مبلغ به ریال" />
                        </div>
                        <div>
                            <label>CcallbackURL:</label>
                            <input type="text" name="callbackURL" value="" placeholder="آدرس برگشتی" />
                        </div>
                        <div>
                            <label>InvoiceID:</label>
                            <input type="text" name="InvoiceID" value="" placeholder="شماره فاکتور" />
                        </div>
                        <div>
                            <label>Payload :</label>
                            <input type="text" name="Payload" value="" placeholder="اطلاعات اضافه" />
                        </div>--%>
                        <div>
                            <label>Token :</label>
                            <input type="text" name="token" value="" placeholder="توکن" />
                        </div>
                        <div>
                            <label>&nbsp;</label>
                            <input type="submit" value="پرداخت" class="submit" />
                        </div>
                    </fieldset>
                </form>

            </td>


            <td style="vertical-align: top;">

                <%--_________________________________________________________مقادیر برگشتی___________________________________________________________--%>

                <fieldset>
                    <legend>مقادیر برگشتی </legend>
                    <div>
                        <asp:Label ID="lblall" runat="server"></asp:Label>
                    </div>
                </fieldset>

                <%--_________________________________________________________تایید یا تراکنش___________________________________________________________--%>

                <form id="form1" runat="server">
                    <div>
                        <fieldset>
                            <legend>نتیجه تایید تراکنش </legend>
                            <table>

                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>
                                </tr>

                            </table>
                        </fieldset>
                    </div>
                </form>

            </td>
        </tr>
    </table>

</body>
</html>
