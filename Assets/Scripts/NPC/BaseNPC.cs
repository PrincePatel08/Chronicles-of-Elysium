using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    public abstract class BaseNPC : MonoBehaviour, IDamageable
    {


        public void Kill()
        {
            Destroy(gameObject);
        }

        public int Health { get; set; } = 100;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
                Kill();
        }
    }
}
