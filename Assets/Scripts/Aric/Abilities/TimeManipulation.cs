using System.Collections;
using UnityEngine;

namespace PrincePatel
{
    /// <summary>
    /// Time Manipulation:
    /// Description: Aric gains the ability to manipulate time to a limited extent. This power allows him to slow down or temporarily freeze certain objects, creating opportunities to navigate through time-sensitive puzzles and challenges.
    /// </summary>
    public class TimeManipulation : Ability
    {
        [SerializeField] private float _slowTimeScale = 0.5f;

        public override void Start()
        {
            base.Start();
        }

        public override void Activate()
        {
            Debug.Log("Time Manipulation Activated");
            _animator.Play(animationName);
            Time.timeScale = _slowTimeScale;
            canUse = false;

            StartCoroutine(UsingAbility());
        }

        public override void Deactivate()
        {
            Debug.Log("Time Manipulation Deactivated");
            Time.timeScale = 1f;
        }

        public void Use()
        {
            if (canUse)
                Activate();
            else
                Deactivate();
        }

        private IEnumerator UsingAbility()
        {
            yield return new WaitForSeconds(duration);
            Deactivate();
            StartCoroutine(Cooldown());
        }
    }
}
