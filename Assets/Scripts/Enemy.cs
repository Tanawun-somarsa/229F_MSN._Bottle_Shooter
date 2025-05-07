using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    
    public int scoreValue = 10; // คะแนนที่เพิ่มเมื่อ Enemy ถูกทำลาย

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            if (ScoreManager.instance != null)
                ScoreManager.instance.AddScore(10);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    
}
