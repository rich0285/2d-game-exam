using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expl : MonoBehaviour
{

    public float LiveTime = 0.3f;

 
    void Update()
    {
        
        LiveTime -= Time.deltaTime;
        if (LiveTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
