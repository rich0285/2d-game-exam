using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class AreaOfDamage : MonoBehaviour
{
    public float radius = 0.5f;
    public int DamageAmount = 50;
    void OnTriggerEnter2D(Collider2D coll)
    {
        
        if (coll.gameObject.tag == "Fireball")
        {
            Debug.Log("Triggered");

            DemonScript demon = coll.gameObject.GetComponent<DemonScript>();
            Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, radius);
            foreach (Collider2D enemy in enemies)
            {
                if (enemy.gameObject.tag == "Enemy")
                {
                    Debug.Log(enemy.name);
                    if (enemy != null)
                    {
                        Debug.Log("maybe");
                       enemy.GetComponent<DemonScript>().demonHealth -= 50;
                    }
                }
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
  
}
