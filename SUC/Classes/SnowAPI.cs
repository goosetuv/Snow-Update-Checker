﻿using RestSharp;
using System;

namespace SUC.Classes
{
    public class SnowAPI
    {
        public IRestResponse GetData(string type = "xml")
        {
            var client = new RestClient("https://snwapi.com/api/1.0?format=" + type)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return (response);
        }

        public static bool VersionCheck(string UserVersion, string APIVersion)
        {
            var Latest = new Version(APIVersion);
            var Installed = new Version(UserVersion);

            if (Latest.CompareTo(Installed) > 0)
            {
                return true;
            }
            else if (Latest.CompareTo(Installed) < 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
