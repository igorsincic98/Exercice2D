using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float _lifeTime;

    

    private void Start()
    {
        Invoke(nameof(DestroyMe), _lifeTime);
    }
    private void DestroyMe()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        PlayerHealth target = other.GetComponent<PlayerHealth>();
        if (target != null)
        {
            target.TakeDamage(1);
        }

    }



}
