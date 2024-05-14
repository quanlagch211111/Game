using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float wSpeed = 3.0f;
    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb =gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        rb.gravityScale = 0;


    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY).normalized * wSpeed;

        if (movement != Vector2.zero)
        {
            rb.velocity = new Vector2(movement.x, movement.y);
            anim.SetBool("Walk", true);
        }
        else
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("Walk", false);
        }
    }

}
