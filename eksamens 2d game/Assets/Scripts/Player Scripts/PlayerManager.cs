using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static float Score ;
    public static int Health =100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D TheCoin)
    {
        if (TheCoin.transform.tag == "Coins")
        {
            Score = Score + 5;

            Destroy(TheCoin.gameObject);
        }

    }
}

