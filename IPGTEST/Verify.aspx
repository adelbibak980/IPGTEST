<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="IPGTEST.Verify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
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

                <form id="form1" runat="server">
                    <fieldset>
                        <legend>تایید تراکنش</legend>
                        <div>
                            <label>Tid:</label>
                            <asp:TextBox ID="Tid" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <label>digitalreceipt:</label>
                            <%--<input type="text" name="digitalreceipt" value="" placeholder="رسید دیجیتال تراکنش" />--%>
                            <asp:TextBox ID="digitalreceipt" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <%--<input type="submit" value="پرداخت" class="submit" />--%>
                            <asp:Button ID="Button1" runat="server" Text="تایید" OnClick="Button1_Click" />
                        </div>
                        <hr />
                        <div>
                            <label>Status:</label>
                            <%--<input type="text" name="digitalreceipt" value="" placeholder="رسید دیجیتال تراکنش" />--%>
                            <asp:TextBox ID="Status" Enabled="false" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <label>ReturnId:</label>
                            <%--<input type="text" name="digitalreceipt" value="" placeholder="رسید دیجیتال تراکنش" />--%>
                            <asp:TextBox ID="ReturnId" Enabled="false" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <label>Message:</label>
                            <%--<input type="text" name="digitalreceipt" value="" placeholder="رسید دیجیتال تراکنش" />--%>
                            <asp:TextBox ID="Message" Enabled="false" runat="server"></asp:TextBox>
                        </div>
                    </fieldset>
                </form>

            </td>
        </tr>
    </table>
</body>
</html>
