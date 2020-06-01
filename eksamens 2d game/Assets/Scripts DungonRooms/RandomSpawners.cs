using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class RandomSpawners : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Coin;
    public GameObject Barrel;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnStuff", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnStuff()
    {
        int randy = Random.Range(-5, 20);
        if (randy > 0)
        {
            Debug.Log("randy>0");
            Instantiate(Coin, transform.position, Quaternion.identity);
            Destroy(gameObject, 2);
        }
        if (randy < 0)
        {
            Debug.Log("randy<0");
            Instantiate(Enemy, transform.position, Quaternion.identity);
            Destroy(gameObject, 2);
        }
        if (randy < 0)
        {
            Debug.Log("randy<0");
            Instantiate(Barrel, transform.position, Quaternion.identity);
            Destroy(gameObject, 2);
        }
        else
        {
            Debug.Log("=0");
            Destroy(gameObject, 2);
        }
    }
}
