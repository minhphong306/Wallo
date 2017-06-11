using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Pollo.model;

namespace Pollo {
    class FirebaseConnect
    {
        private IFirebaseConfig config;
        private IFirebaseClient client;

        public void InitFirebase()
        {
             config = new FirebaseConfig {
                AuthSecret = "dNU6O9DNokjtAWzCkLGr3AlvjyviyI1Egdw2ld9S",
                BasePath = "https://wallo-250b4.firebaseio.com/"
            };
             client = new FirebaseClient(config);
        }

        public async void doSomething()
        {
            FirebaseResponse response = await client.GetAsync("TODO");
            walloModel todo = response.ResultAs<walloModel>();
        }

        public async void pushData(string text)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Name", text);
            var response = await client.PushAsync("TODO/", values);
            
        }
    }
}
