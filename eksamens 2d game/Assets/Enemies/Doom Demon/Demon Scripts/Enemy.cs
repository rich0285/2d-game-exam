using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 movement;

    public Animator animator;
    public int attackTimer;



    void Start()
    {
     
    }

    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator.SetFloat("X input", movement.normalized.x);
        animator.SetFloat("Y input", movement.normalized.y);
        animator.SetInteger("Charge timer", attackTimer);
        FindPlayer();
        AttackPlayer();
    }
    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    void OnTriggerEnter2D(Collider2D targetCollider2D)
    {
        //check for player 
            //then Hurt player with damage
    }
    void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    void FindPlayer()
    {
        if (player != null)
        {   animator.SetBool("IsRunning",true);
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
    }

   IEnumerator WaitAndCharge()
   {
       moveSpeed = 0;
        yield return new WaitForSeconds(0001);
        moveSpeed = 3f;
        StartCoroutine(Charge());
        /*Charge();*/
      

    }

    IEnumerator Charge()
    {
        moveSpeed = moveSpeed + 5f;
        Vector2 charger = new Vector2(0.0f, 0.0f);
        MoveCharacter(charger);
        yield return new WaitForSeconds(1);
        moveSpeed = 3f;
        yield return new WaitForFixedUpdate();
        StopAllCoroutines();
    }

    /* void Charge()
     {
         if (movement.normalized.x > movement.normalized.y)
         {
             Vector2 chargerX = new Vector2(player.position.x, 0.0f);
             rb.MovePosition((Vector2)transform.position + (chargerX * 120f * Time.deltaTime));
         }
         else
         {
             Vector2 chargerY = new Vector2(player.position.x, 0.0f);
             rb.MovePosition((Vector2)transform.position + (chargerY * 120f * Time.deltaTime));
         }
     }*/

    void AttackPlayer()
    {
        if (attackTimer==200)
        {
            StartCoroutine(WaitAndCharge());
            attackTimer = 0;
        }
        else
        {
            attackTimer += 1; 
        }
    }

    
}
