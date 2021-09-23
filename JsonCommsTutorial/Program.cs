using JsonCommsTutorial.Models;
using System;

namespace JsonCommsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var server = new DummyServer();
            var client = new DummyClient(server);




            var requestModel = new ZombieDataRequestModel("Liverpool", 2);

            ZombieDataResponseModel result = client.MakeRequest(requestModel);

            // TODO: Look at result.
        }
    }
}
