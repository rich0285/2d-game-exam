using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class StarterDestroyer : MonoBehaviour
{
    public float waitTime = 20f;

    void Start()
    {
        Destroy(gameObject, waitTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        for (int i = 0; i < waitTime; i++)
        {
            if (other.gameObject.name != "Character")
            {
                Destroy(other.gameObject);
            }
        }


    }

  
}
