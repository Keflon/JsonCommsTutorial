using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonCommsTutorial.Models
{
    public class ZombieDataResponseModel
    {
        public ZombieDataResponseModel(ZombieHordeInfo zombieInfo, WeaponAvailabilityInfo weaponInfo)
        {
            ZombieInfo = zombieInfo;
            WeaponInfo = weaponInfo;
        }

        public ZombieHordeInfo ZombieInfo { get; }
        public WeaponAvailabilityInfo WeaponInfo { get; }
    }

    public class WeaponAvailabilityInfo
    {
        public WeaponAvailabilityInfo(ExplosivesInfo explosives, ProjectileInfo projectiles)
        {
            Explosives = explosives;
            Projectiles = projectiles;
        }

        public ExplosivesInfo Explosives { get; }
        public ProjectileInfo Projectiles { get; }
    }

    public class ProjectileInfo
    {
        public ProjectileInfo(IEnumerable<string> projectileWeapons)
        {
            ProjectileWeapons = projectileWeapons;
        }

        public IEnumerable<string> ProjectileWeapons { get; }
    }

    public class ExplosivesInfo
    {
        public ExplosivesInfo(IEnumerable<string> explodingWeapons)
        {
            ExplodingWeapons = explodingWeapons;
        }

        public IEnumerable<string> ExplodingWeapons { get; }
    }

    public class ZombieHordeInfo
    {
        public ZombieHordeInfo(string hordeInfo)
        {
            HordeInfo = hordeInfo;
        }

        public string HordeInfo { get; }
    }
}
