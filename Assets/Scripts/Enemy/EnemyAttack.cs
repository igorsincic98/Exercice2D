using Player;
using UnityEngine;

namespace Enemy
{
    public class EnemyAttack : MonoBehaviour
    {

        private void Start()
        {
        
        }
        private void DestroyMe()
        {
            Destroy(gameObject);
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            PlayerHealth target = other.GetComponent<PlayerHealth>();
            if (target != null)
            {
                target.TakeDamage(1);
            }

        }



    }
}
