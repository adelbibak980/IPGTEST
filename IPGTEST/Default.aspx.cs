using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPGTEST
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string responceCode = Request.Form["respcode"];
                string terminalID = Request.Form["terminalid"];
                string digitalReceipt = Request.Form["digitalreceipt"];

                if (responceCode == "0")
                {
                    string url2 = "https://sepehr.shaparak.ir:8081/V1/PeymentApi/Advice?digitalreceipt=" + digitalReceipt + "&Tid=" + terminalID;
                    string ret2 = PostMethod(url2);
                    Label9.Text = ret2;
                }


                foreach (string key in Request.Form)
                {
                    string a = Request.Form[key];
                    lblall.Text = lblall.Text + "<br />" + key + " : " + "<b dir='ltr'>" + a + "</b>";
                }
            }
        }

        public static string PostMethod(string Url)
        {
            string result;
            HttpWebRequest Request;
            WebResponse webResponse = null;
            try
            {
                Request = WebRequest.Create(Url.Remove(Url.IndexOf("?"))) as HttpWebRequest;

                Request.Method = "POST";
                Request.ContentType = "application/x-www-form-urlencoded";

                string parameters = Url.Substring(Url.IndexOf("?") + 1);

                byte[] byteArray = Encoding.UTF8.GetBytes(parameters);
                Request.ContentLength = byteArray.Length;

                Stream dataStream = Request.GetRequestStream();

                dataStream.Write(byteArray, 0, byteArray.Length);

                dataStream.Close();

                webResponse = Request.GetResponse();
                StreamReader reader = new StreamReader(webResponse.GetResponseStream());

                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception exp)
            {
                // Log("HttpPost", "ErrorPostUrl", string.Format("PostUrl=>url:{0}<hr>message:{1}<hr>innerExeption:{2}", Url, exp.Message, exp.InnerException), CurrentContext, Database.Log.LogsBL.LogType.ErrorLog);

                result = "Error";
            }
            finally
            {
                if (webResponse != null)
                {
                    webResponse.Close(); //Close webresponse connection
                }
                webResponse = null; //To clear up the webresponse
                Request = null; //To clear up the webrequest
            }
            return result;
        }


    }
}