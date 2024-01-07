using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        [SerializeField] private float lifeTime = 5f;
        [SerializeField] private int damage = 10;
        [SerializeField] private GameObject hitEffect;

        private void Start()
        {
            Destroy(gameObject, lifeTime);
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.CompareTag("Enemy"))
            {
                //collision.gameObject.GetComponent<IDamageable>().TakeDamage(damage);
                Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
