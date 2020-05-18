using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    public Camera cam;
    public Animator animator;
    Vector2 movement;
    Vector2 mousePos;
    private Vector2 lookDirection;
   
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        lookDirection = mousePos - rb.position;
        animator.SetFloat("Mouse Horizontal", lookDirection.x);
        animator.SetFloat("Mouse Vertical", lookDirection.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    
        
      
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    
    }

}