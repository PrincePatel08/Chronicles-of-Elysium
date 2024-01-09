using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    public class NPC_Controller : BaseNPC
    {
        public event Action OnAttack;
        public event Action OnTargetSeen;
        public event Action OnTargetLost;
        public event Action OnTarget;

        protected override void Awake()
        {
            base.Awake();
        }

        protected void Start()
        {
            agent.speed = walkSpeed;
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void Update()
        {

        }
    }
}
