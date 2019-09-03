using DawaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace DawaService.Models
{
    public class Client
    {
        private HttpClient client;

        public Client()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://dawa.aws.dk/");
        }

        public HttpClient GetClient(int timeout)
        {
            client.Timeout = new TimeSpan(0, timeout, 0);

            return client;
        }
    }
}
