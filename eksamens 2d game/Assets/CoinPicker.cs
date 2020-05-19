using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private float Score = 0f;

    void OnTriggerEnter2D(Collider2D TheCoin)
    {
        if (TheCoin.transform.tag == "Coins")
        {
            Destroy(TheCoin.gameObject);
        }
        
    }
}
