using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWhenTimesOver : MonoBehaviour
{
    public float LiveTime = 5;
    void Update()
    {
        LiveTime -= Time.deltaTime;
        if (LiveTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      Destroy(gameObject);

    }
}
