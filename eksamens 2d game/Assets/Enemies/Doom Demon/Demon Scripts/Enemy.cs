using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 movement;

    public Animator animator;
   
   
   

    void Start()
    {

    }

    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator.SetFloat("X input", movement.normalized.x);
        animator.SetFloat("Y input", movement.normalized.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        findPlayer();
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    void findPlayer()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
    }
}
