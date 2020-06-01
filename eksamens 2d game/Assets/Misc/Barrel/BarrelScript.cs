using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BarrelScript : MonoBehaviour
{
    public ParticleSystem explosion;
    public GameObject coin;
    public Transform player;
    public float Pdistance;
   
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        Pdistance = Vector3.Distance(transform.position, player.position);
        }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Fireball")
        {
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Instantiate(coin, transform.position, Quaternion.identity);
            if (Vector3.Distance(transform.position, player.position) < 1.048197)
            {
                PlayerManager.Health -= 5;
            }
        }
    }

    
}
