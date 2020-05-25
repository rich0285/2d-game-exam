using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {


            SceneManager.LoadScene(0);
            RoomTemplates.spawnedBoss = false;
            RoomTemplates.waitTime = 5;
            GiveDamageToPlayer.demonHealth = 50;
        }

    }
}
