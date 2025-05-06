using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float angularV, torque;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        /*rb.angularVelocity = angularV;*/

        rb.angularVelocity = angularV;

        rb.AddTorque(torque);

    }
}
