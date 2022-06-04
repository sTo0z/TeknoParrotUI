﻿using System.Net.Http;

namespace TeknoParrotUi.Common.InputProfiles.Helpers
{
    class WMMT3Cards
    {
        private static readonly HttpClient client = new HttpClient();
        public static void InsertCard()
        {
            // YaCardEmu uses a nice and simple GET api to do stuff via the webui,
            // so we can replicate it in basically one line. :)
            client.GetStringAsync("http://127.0.0.1:8080/actions?insert=");
        }
    }
}
