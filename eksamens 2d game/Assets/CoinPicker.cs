using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPicker : MonoBehaviour
{
    public static float Score;
    
    void OnTriggerEnter2D(Collider2D TheCoin)
    { 
        if (TheCoin.transform.tag == "Coins")
        {
            Score = Score + 5;
            
            Destroy(TheCoin.gameObject);
        }
        
    }
}
