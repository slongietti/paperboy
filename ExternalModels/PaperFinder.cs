using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Volare.PaperBoy.ExternalModels;

namespace Volare.PaperBoy.ExternalModels
{
    public static class PaperFinder
    {
        private const string OliveURL = "http://digital.olivesoftware.com/Olive/ODN/CharlotteObserver/get/";
        private const string CHO= "CHO";
        private const string URLSpace = "%2F";

        public static void GetPaper(DateTime date,string StoragePath = "")
        {
            string ts = OliveURL + DateHiffen(date) + "/settings.ashx?kind=context&href=" + DateWithSpace(date);
            Olive.Publication.Date pubDate = GetJSON<Olive.Publication.Date>(ts);
            string fulldet = OliveURL + DateHiffen(date) + "/prxml.ashx?kind=doc&href=" + DateWithSpace(date) +
                "&ts=" + pubDate.timestamp;
            Olive.Publication.Details pubDetails = GetJSON<Olive.Publication.Details>(fulldet);

            string PDFURL = OliveURL + "pdf.ashx?kind=file&doc=" + DateWithSpace(date) + "&sk=" + pubDetails.sk;

            byte[] result = null;
            byte[] buffer = new byte[4097];

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(PDFURL);
            request.KeepAlive = false;
            request.Method = WebRequestMethods.Http.Get;
            Stream resp = request.GetResponse().GetResponseStream();
            MemoryStream ms = new MemoryStream();

            int count = 0;
            do
            {
                count = resp.Read(buffer, 0, buffer.Length);
                ms.Write(buffer, 0, count);
            }
            while (count > 0);

            result = ms.ToArray();

            if(!string.IsNullOrEmpty(StoragePath))
            {
                StoragePath += "\\" + date.ToString("yyyy-MM-dd") + ".pdf";
                FileStream fs = new FileStream(StoragePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                fs.Write(result, 0, result.Length);

                fs.Close();
                ms.Close();
                resp.Close();
            }

        }


        private static T GetJSON <T>(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.KeepAlive = false;
            request.Method = WebRequestMethods.Http.Get;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Encoding enc = ASCIIEncoding.ASCII;
            StreamReader sr = new StreamReader(response.GetResponseStream(), enc);
            string json = sr.ReadToEnd();
            return JsonConvert.DeserializeObject<T>(json);  
        }

        private static string DateHiffen(DateTime d)
        {
           return CHO + "-" + d.ToString("yyyy-MM-dd");
        }

        private static string DateWithSpace(DateTime d)
        {
            return CHO + URLSpace + d.Year.ToString() +
                URLSpace + d.Month.ToString() + URLSpace + d.Day.ToString();
        }
    }
}
