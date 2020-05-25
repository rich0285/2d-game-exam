using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamageToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerManager.Health -= 5;
        }
    }
}
