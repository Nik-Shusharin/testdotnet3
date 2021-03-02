using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace testdotnet
{
    public class unsec15
    {
        public string GetRequest()
        {
            var MyToken = "asdfERWQEFASDFAWERWR345FASDFAS34fASFDADSFASDF34rqwefSAFDSADFA";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.google.com");
            request.Headers.Add("authorization", "Bearer asdfERWQEFASDFAWERWR345FASDFAS34fASFDADSFASDF34rqwefSAFDSADFA");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
