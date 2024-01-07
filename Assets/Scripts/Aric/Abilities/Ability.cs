using StarterAssets;
using System.Collections;
using UnityEngine;

namespace PrincePatel
{
    public abstract class Ability : MonoBehaviour
    {
        public bool canUse;
        public float duration;
        public float cooldownTime;
        public string animationName;

        public AudioClip abilitySound;
        public GameObject abilityEffect;

        protected ThirdPersonController _controller;
        protected Animator _animator;

        public virtual void Start()
        {
            _controller = GetComponentInParent<ThirdPersonController>();
            _animator = GetComponentInParent<Animator>();
        }

        public abstract void Activate();
        public abstract void Deactivate();

        protected IEnumerator Cooldown()
        {
            yield return new WaitForSeconds(cooldownTime);
            canUse = true;
        }
    }
}
