using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    

    public float LiveTime = 5;
    public GameObject FireballImpact;
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
        if (coll.gameObject.tag == "Barrel")
        {
            Instantiate(FireballImpact, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
        if (coll.gameObject.tag == "Walls")
        {
            Instantiate(FireballImpact, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }

        if (coll.gameObject.tag == "Enemy")
        {
            DemonScript enemy = coll.gameObject.GetComponent<DemonScript>();
            if (enemy != null)
            {
                enemy.TakeDamage(4);
                DestroyFireball();
            }
        }
    }
   
    void DestroyFireball()
    {
        Instantiate(FireballImpact, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}