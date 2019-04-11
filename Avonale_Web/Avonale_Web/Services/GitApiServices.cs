using Avonale_Web.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace Avonale_Web.Services
{
    public class GitApiServices
    {
        public string BaseUrl
        {
            get
            {
                return "https://api.github.com/users/Xedou/repos";
            }
        }

        public List<Repositorio> GetRepositorios()
        {
            HttpWebRequest webRequest = WebRequest.Create(BaseUrl) as HttpWebRequest;
            dynamic jsonObj = null;

            if (webRequest != null)
            {
                webRequest.Method = "GET";
                webRequest.UserAgent = "Anything";
                webRequest.ServicePoint.Expect100Continue = false;

                try
                {
                    using (StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
                    {
                        string reader = responseReader.ReadToEnd();
                        jsonObj = JsonConvert.DeserializeObject<List<Repositorio>>(reader);
                    }
                }
                catch
                {
                    return jsonObj;
                }
            }

            return jsonObj;
        }

    }

}