using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    /// <summary>
    /// Time Manipulation:
    /// Description: Aric regains some health.
    /// </summary>
    public class RegenerateHealth : Ability
    {
        public override void Activate()
        {
            Debug.Log("Time Manipulation Activated");
            _animator.Play(animationName);

            canUse = false;
            StartCoroutine(Cooldown());
        }

        public override void Deactivate()
        {
            Debug.Log("Time Manipulation Deactivated");
        }
    }
}
