using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static float Score ;
    public static int Health;
    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
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

    void OnTriggerCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.collider.GetComponent<Enemy>()
        if (enemy != null)
        {
            DamageTaken();
        }

    }

    void DamageTaken()
    {
        Health -= 10;
    }
}
