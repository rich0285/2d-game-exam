using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DemonScript : MonoBehaviour
{
    public float moveSpeed = 3f;
    // public static int demonHealth = 50;
    public  int demonHealth = 50;
    private bool isAgrro;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public Animator animator;
    public float maxDist = 10.5f;
    public float distance;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator.SetFloat("X input", movement.normalized.x);
        animator.SetFloat("Y input", movement.normalized.y);

        distance = Vector3.Distance(transform.position, player.position);

        if (Vector3.Distance(transform.position, player.position) < maxDist)
        {
            isAgrro = true;
            FindPlayer();

        }
        else if (Vector3.Distance(transform.position, player.position) >= maxDist)
        {
            isAgrro = false;
            animator.SetBool("IsRunning", false);
            rb.MovePosition(Vector3.zero);
        }

    }
    private void FixedUpdate()
    {


        if (isAgrro == false)
        {
            StopMoveCharacter(movement);
        }

        if (isAgrro == true)
        {
            MoveCharacter(movement);
        }
    }

    void MoveCharacter(Vector2 direction)
    {
        moveSpeed = 3f;
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    void StopMoveCharacter(Vector2 direction)
    {
        moveSpeed = 0f;
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    void FindPlayer()
    {
        if (player != null && isAgrro == true)
        {

            animator.SetBool("IsRunning", true);
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
        }
        else
        {

            animator.SetBool("IsRunning", false);
            isAgrro = false;
        }
    }

    void EnemyDie()
    {
        PlayerManager.Score += 50;
        Destroy(gameObject);
    }
    // Take damage from player
    public void TakeDamage(int dmg)
    {
        this.demonHealth -= dmg;
        if (demonHealth <= 0)
        {
            EnemyDie();
        }
    }
   









}