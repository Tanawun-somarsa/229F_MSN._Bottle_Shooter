using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // ✅ ใช้ Transform เพื่อดึงตำแหน่ง
    public float moveSpeed = 2f;

    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)(direction * moveSpeed * Time.deltaTime);
        }
    }
}
