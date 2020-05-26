using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float waitTime=20f;

   void Start()
    {
        Destroy(gameObject,waitTime);
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SpawnPoint")
        {
            Destroy(other.gameObject);
        }
    }
}
