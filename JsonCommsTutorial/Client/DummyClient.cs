using JsonCommsTutorial.Models;
using Newtonsoft.Json;
using System;

namespace JsonCommsTutorial
{
    internal class DummyClient
    {
        private DummyServer _server;

        public DummyClient(DummyServer server)
        {
            _server = server;
        }

        public ZombieDataResponseModel MakeRequest(ZombieDataRequestModel requestModel)
        {
            string serialisedRequestModelAsJson = JsonConvert.SerializeObject(requestModel);

            string resultAsJson = _server.GetZombieData(serialisedRequestModelAsJson);

            ZombieDataResponseModel result = JsonConvert.DeserializeObject<ZombieDataResponseModel>(resultAsJson);

            return result;
        }
    }
}