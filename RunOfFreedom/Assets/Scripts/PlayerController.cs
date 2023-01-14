using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isGround;
    [SerializeField] LayerMask whatIsGround;

    private Rigidbody2D rb;
    private Collider2D myCollider;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }


    private void Update()
    {
        isGround = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(isGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
            
        }
    }
}
