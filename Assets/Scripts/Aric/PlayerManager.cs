using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    public class PlayerManager : MonoBehaviour, IDamageable
    {
        public bool isAlive = true;

        private ThirdPersonController controller;
        

        private void Awake()
        {
            controller = GetComponent<ThirdPersonController>();
        }

        private void Update()
        {
            // If the player is dead, disable the controller
            if(!isAlive)
            {
                controller.enabled = false;
            }
        }

        #region IDamageable
        public int Health { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        #endregion
    }
}
