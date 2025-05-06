using UnityEngine;

public class Player_movement : MonoBehaviour
{
    Rigidbody2D rd2d; //private variable

    Vector2 moveInput; //for walk woth addforce

    //walk left-right
    float move; //store input form player
    [SerializeField] float speed;

    //jump
    [SerializeField] float jumpForce;
    [SerializeField] bool isJumping;


    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //walk with addforce
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rd2d.AddForce(moveInput * speed);
        /*
                //walk left-right
                move = Input.GetAxis("Horizontal");
                rd2d.linearVelocity = new Vector2(move * speed, rd2d.linearVelocity.y);
        */
        //jump
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rd2d.AddForce(new Vector2(rd2d.linearVelocity.x, jumpForce));
            Debug.Log("Jump!"); //for debugging
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
