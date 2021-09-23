using JsonCommsTutorial.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JsonCommsTutorial
{
    internal class DummyServer
    {
        public DummyServer()
        {
        }

        public string GetZombieData(string serialisedRequestModelAsJson)
        {
            ZombieDataRequestModel request = JsonConvert.DeserializeObject<ZombieDataRequestModel>(serialisedRequestModelAsJson);

            if(request.RegionCode == "Liverpool")
            {
                var explosives = new ExplosivesInfo(new List<string>() { { "a" }, {"b" } });
                var projectiles = new ProjectileInfo(new List<string>() { { "a" }, {"b" } });


                var weaponInfo = new WeaponAvailabilityInfo(explosives, projectiles);

                var zombieInfo = new ZombieHordeInfo("Some text here");

                var zombieDataResponseModel = new ZombieDataResponseModel(zombieInfo, weaponInfo);

                var zombieDataResponseModelAsString = JsonConvert.SerializeObject(zombieDataResponseModel);

                return zombieDataResponseModelAsString;
            }
            else
            {
                throw new NotImplementedException("TODO:");
            }
        }
    }
}