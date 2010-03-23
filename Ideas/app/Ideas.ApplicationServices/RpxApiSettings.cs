using System;
using System.Net;
using RPXLib.Interfaces;

namespace Ideas.ApplicationServices
{
    public class RpxApiSettings : IRPXApiSettings
    {
        public string ApiKey
        {
            get { return "aoneokdfiabjmopmdkop"; }
        }

        public string ApiBaseUrl
        {
            get { return "https://rpxnow.com/api/v2/"; }
        }

        public IWebProxy WebProxy
        {
            get { return null; }
        }
    }
}