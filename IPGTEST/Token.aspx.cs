using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPGTEST
{
    public partial class Token : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender1, EventArgs e)
        {
            IPGToken.TokenRequest tokenRequest =
                new IPGToken.TokenRequest();

            tokenRequest.TerminalId = System.Convert.ToInt64(TerminalId.Text.Trim());
            tokenRequest.Amount = System.Convert.ToInt64(Amount.Text.Trim());
            tokenRequest.CallbackUrl = CallbackUrl.Text.Trim();
            tokenRequest.InvoiceId = InvoiceId.Text.Trim();
            tokenRequest.Payload = Payload.Text.Trim();





            try
            {
                /////////////////////////SOAP/////////////////////////
                IPGToken.TokenClient tokenClient =
                    new IPGToken.TokenClient();

                var Resp = tokenClient.GetToken(tokenRequest);
                Status.Text = Resp.Status.ToString();
                AccessToken.Text = Resp.Accesstoken;


                /////////////////////////SOAP/////////////////////////



                /////////////////////////REST/////////////////////////
                //var client = new HttpClient { BaseAddress = new Uri("https://sepehr.shaparak.ir:8081") };
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //var myContent = new JavaScriptSerializer().Serialize(tokenRequest);
                //var buffer = Encoding.UTF8.GetBytes(myContent);
                //var byteContent = new ByteArrayContent(buffer);
                //byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


                //var respnseMessage = client.PostAsync("V1/PeymentApi/GetToken", byteContent);

                //var responseJson = respnseMessage.Result;


                //string res = responseJson.Content.ReadAsStringAsync().Result;

                //var Resp = new JavaScriptSerializer().Deserialize<IPGToken.TokenResponse>(res);
                //Status.Text = Resp.Status.ToString();
                //AccessToken.Text = Resp.Accesstoken;
                /////////////////////////REST/////////////////////////


            }
            catch (Exception ex)
            {

            }



        }
    }
}