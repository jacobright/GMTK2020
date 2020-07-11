using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 4;
    

    private Rigidbody2D rb;
    private Animator ani;

    private bool isWalking;
    private bool facingFront;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        ani = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mvmt = Vector2.zero;

        mvmt = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;

        // <Animations>
        if (Input.GetAxisRaw("Vertical") != 0) {
            if (Input.GetAxisRaw("Vertical") < 0)
                facingFront = true;
            else
                facingFront = false;

            isWalking = true;
        }
        else if (Input.GetAxisRaw("Horizontal") != 0) {
            isWalking = true;
        }
        else {
            isWalking = false;
        }

        ani.SetBool("isWalking", isWalking);
        ani.SetBool("facingFront", facingFront);
        // </Animations>


        rb.velocity = mvmt;
    }
}
