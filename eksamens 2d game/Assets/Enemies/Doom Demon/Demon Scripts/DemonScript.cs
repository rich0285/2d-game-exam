using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DemonScript : MonoBehaviour
{
    public float moveSpeed = 3f;
    public static int demonHealth = 50;

    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public Animator animator;
  

    void Start()
    {
      player= GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator.SetFloat("X input", movement.normalized.x);
        animator.SetFloat("Y input", movement.normalized.y);
        FindPlayer();
        EnemyDie();
    }
    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    void FindPlayer()
    {
        if (player != null)
        {
            animator.SetBool("IsRunning", true);
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
    }

    void EnemyDie()
    {
        if (demonHealth == 0)
        {
            PlayerManager.Score += 50;
            Destroy(this.gameObject);
        }
    }
    // Take damage from player



}