using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5.CallAPIandCount
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GET
            string strurltest = String.Format("https://gturnquist-quoters.cfapps.io/api/random");
            WebRequest requestObjGet = WebRequest.Create(strurltest);

            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();

            string strresulttest = null;
            using(Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                List<int> cnt = new List<int>();
                for(int i=1; i<=strresulttest.Length; i++)
                {
                    if (strresulttest[i]==i)
                    {
                        cnt[i]++;
                    }
                }

                int temp = 0;
                for (int i = 0; i < cnt.Count() - 1; i++)
                {
                    for (int j = 0; j < cnt.Count() - 1 - i; j++)
                    {
                        if (cnt[j] < cnt[j + 1])
                        {
                            temp = cnt[j];
                            cnt[j] = cnt[j + 1];
                            cnt[j + 1] = temp;
                        }
                    }
                }
                
                for(int i=0; i<cnt.Count(); i++)
                {
                    Console.WriteLine("count:{0}", cnt[i]);
                }


                sr.Close();
            }


            //POST
            string strUrl = String.Format("https://gturnquist-quoters.cfapps.io/api/random");
            WebRequest requestObjPost = WebRequest.Create(strUrl);
            requestObjPost.Method = "POST";
            requestObjPost.ContentType = "application/json";

            string postData = "{\'id\':\'testdata\',\'quote\':\'testbody\'}";

            using(var streamWriter = new StreamWriter(requestObjPost.GetRequestStream()))
            {
                streamWriter.Write(postData);
                streamWriter.Flush();
                streamWriter.Close();

                var httpResponse = (HttpWebResponse)requestObjPost.GetResponse();

                using(var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result2 = streamReader.ReadToEnd();
                }
            }

        }
    }
}