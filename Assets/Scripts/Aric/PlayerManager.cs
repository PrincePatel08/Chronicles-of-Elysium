using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    public class PlayerManager : MonoBehaviour, IDamageable
    {
        private ThirdPersonController controller;
        private Animator animator;
        private StarterAssetsInputs inputs;
        

        private void Awake()
        {
            controller = GetComponent<ThirdPersonController>();
            inputs = GetComponent<StarterAssetsInputs>();
            animator = GetComponent<Animator>();
        }

        private void Start()
        {
            TakeDamage(22);
            RegenerateHealth();
        }

        private void Update()
        {
            if(inputs.mouseLeftClick)
                Attack1();
            else if(inputs.mouseRightClick)
                Attack2();
        }

        public void Attack1()
        {
            inputs.mouseLeftClick = false;
            animator.Play("Attack 1");
        }

        public void Attack2()
        {
            inputs.mouseRightClick = false;
            animator.Play("Attack 2");
        }

        public void KillPlayer()
        {

        }

        #region IDamageable_Health
        public int Health { get; set; } = 100;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            GamePlayUI.Instance.UpdatePlayerHealthBar(Health);
            if(Health <= 0)
                KillPlayer();
        }

        public void RegenerateHealth()
        {
            StartCoroutine(RegenerateHealthCoroutine());
        }

        IEnumerator RegenerateHealthCoroutine()
        {
            yield return new WaitForSeconds(.2f);
            Health++;
            GamePlayUI.Instance.UpdatePlayerHealthBar(Health);

            if (Health < 100)
                StartCoroutine(RegenerateHealthCoroutine());
        }
        #endregion
    }
}
