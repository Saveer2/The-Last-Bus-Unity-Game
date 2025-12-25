using UnityEngine;

public class loid : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private float movespeed = 2.1f;
    [SerializeField] private bool facingright = true;

    private float xinput;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        Handleinput();
        HandleMovement();
        Handle_Animation();
        Handleflip();
    }

    private void Handleflip()
    {
        if(rb.linearVelocity.x > 0 && facingright == false)
        {
            flip();
        }else if(rb.linearVelocity.x < 0 && facingright == true)
        {
            flip();
        }
    }

    private void flip()
    {
        transform.Rotate(0, 180, 0);
        facingright = !facingright;
    }

    private void Handleinput()
    {
        xinput = Input.GetAxisRaw("Horizontal");
    }

    private void HandleMovement()
    {
        rb.linearVelocity = new Vector2(xinput * movespeed, rb.linearVelocity.y);
    }

    private void Handle_Animation()
    {
        anim.SetFloat("xVelocity", rb.linearVelocity.x);
    }
}
