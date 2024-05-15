using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float wSpeed = 3.0f;
    Rigidbody2D rb;
    Animator anim;
    float currentSpeed = 0;
    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        rb =gameObject.GetComponent<Rigidbody2D>();
        //anim = gameObject.GetComponent<Animator>();
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
        isMoving = false;
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");


        //Vector2 movement = new Vector2(moveX, moveY).normalized * wSpeed;

        //if (movement != Vector2.zero)
        //{
        //    rb.velocity = new Vector2(movement.x, movement.y);
        //    //anim.SetBool("Walk", true);
        //}
        //else
        //{
        //    rb.velocity = Vector2.zero;
        //    //anim.SetBool("Walk", false);
        //}
        ChangeSpeed(moveX, moveY);
        if(moveX != 0)
        {
            isMoving = true;
            gameObject.GetComponent<Transform>().Translate(Vector3.right * moveX * currentSpeed * Time.deltaTime);

        }
        if(moveY != 0)
        {
            isMoving = true;
            gameObject.GetComponent<Transform>().Translate(Vector3.up * moveY * currentSpeed * Time.deltaTime);
        }

        if (isMoving)
        {
            //anim.SetBool("Walk", true);
        }
        else
        {
            //anim.SetBool("Walk", false);
        }
    }

    void ChangeSpeed(float inputHorDirection, float inputVerDirection)
    {
        if (inputHorDirection != 0 || inputVerDirection != 0)
        {
            currentSpeed += 0.75f;
            if (currentSpeed >= wSpeed)
                currentSpeed = wSpeed;
        }
        else
        {
            currentSpeed -= 0.5f;

            if (currentSpeed <= 0)
            {
                currentSpeed = 0;
            }
        }
    }

}
