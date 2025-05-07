using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float destroyTime = 1f;
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destroy enemy
            Destroy(gameObject);       // Destroy bullet
        }
    }
}
