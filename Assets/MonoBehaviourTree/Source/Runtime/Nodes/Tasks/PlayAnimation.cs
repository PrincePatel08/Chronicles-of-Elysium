using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MBT
{
    [AddComponentMenu("")]
    [MBTNode(name = "Tasks/Play Animation")]
    public class PlayAnimation : Leaf
    {
        [SerializeField]
        private string animationName = "Idle";

        public override NodeResult Execute()
        {
            GetComponentInParent<Animator>().Play(animationName);
            return NodeResult.success;
        }
    }
}
