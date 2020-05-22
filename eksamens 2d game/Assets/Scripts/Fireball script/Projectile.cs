using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float LiveTime = 5;
    public GameObject FireballImpact;

    public static float DamageAmount = 10;

    void Update()
    {
        LiveTime -= Time.deltaTime;
        if (LiveTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        // do some damage
        if (coll.gameObject.tag== "Enemy")
        {
            
        }

        // Dissapere on wall hit
        if (coll.gameObject.tag == "Walls")
        {
            
            Instantiate(FireballImpact, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
    }
}
