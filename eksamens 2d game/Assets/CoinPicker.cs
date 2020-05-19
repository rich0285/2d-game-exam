using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private float Score = 0f;

    void OnTiggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "Coins")
        {
            Destroy(this.gameObject);
        }
        
    }
}
