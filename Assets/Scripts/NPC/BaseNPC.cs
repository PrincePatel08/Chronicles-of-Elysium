using UnityEngine;
using UnityEngine.AI;

namespace PrincePatel
{
    public abstract class BaseNPC : MonoBehaviour, IDamageable
    {
        [SerializeField] protected Transform target;
        [SerializeField] protected float walkSpeed;
        [SerializeField] protected float runSpeed;
        [SerializeField] protected float attackRange;
        [SerializeField] protected float attackRate;
        [SerializeField] protected float attackDamage;
        [SerializeField] protected float fieldOfView;
        [SerializeField] protected float viewDistance;
        [SerializeField] protected float maxChaseDistance;


        protected Animator animator;
        protected NavMeshAgent agent;
        [SerializeField] protected NPCAttackType attackType;

        protected virtual void Awake()
        {
            animator = GetComponent<Animator>();
            agent = GetComponent<NavMeshAgent>();
        }

        public void Kill()
        {
            animator.Play("Death");
            Destroy(gameObject, 5f);
        }

        public int Health { get; set; } = 100;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
                Kill();
        }
    }

    public enum NPCAttackType
    {
        Melee,
        Ranged
    }
}
