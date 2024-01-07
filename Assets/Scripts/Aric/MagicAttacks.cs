using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    public class MagicAttacks : MonoBehaviour
    {
        public GameObject projectile1;
        public GameObject projectile2;
        public Transform projectileSpawnPoint;

        public void FireProjectile1()
        {
            Instantiate(projectile1, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        }

        public void FireProjectile2()
        {
            Instantiate(projectile2, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        }
    }
}
