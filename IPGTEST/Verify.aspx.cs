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
    public partial class Verify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender1, EventArgs e)
        {
            IpgWS.FunctionRequest functionRequest =
                new IpgWS.FunctionRequest();

            functionRequest.Tid = System.Convert.ToInt64(Tid.Text.Trim());
            functionRequest.DigitalReceipt = digitalreceipt.Text;
            try
            {
                /////////////////////////SOAP/////////////////////////
                IpgWS.IpgClient ipgClient =
                    new IpgWS.IpgClient();
                var Resp = ipgClient.Advice(functionRequest);
                ReturnId.Text = Resp.ReturnId;
                Status.Text = Resp.Status;
                Message.Text = Resp.Message;
                /////////////////////////SOAP/////////////////////////



                /////////////////////////REST/////////////////////////
                //var client = new HttpClient { BaseAddress = new Uri("https://sepehr.shaparak.ir:8081") };
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //var myContent = new JavaScriptSerializer().Serialize(functionRequest);
                //var buffer = Encoding.UTF8.GetBytes(myContent);
                //var byteContent = new ByteArrayContent(buffer);
                //byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


                //var respnseMessage = client.PostAsync("V1/PeymentApi/Advice", byteContent);

                //var responseJson = respnseMessage.Result;


                //string res = responseJson.Content.ReadAsStringAsync().Result;

                //var Resp = new JavaScriptSerializer().Deserialize<DTO.Response>(res);
                //ReturnId.Text = Resp.ReturnId;
                //Status.Text = Resp.Status;
                //Message.Text = Resp.Message;
                /////////////////////////REST/////////////////////////




            }
            catch (Exception ex)
            {

            }



        }
    }
}