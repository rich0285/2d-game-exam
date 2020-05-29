using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public static float GameLevel;
        void OnTriggerEnter2D(Collider2D other)
        {
            if (GameLevel == 5)
            {
                SceneManager.LoadScene(3);
                GameLevel = 0;
                PlayerManager.Score = 0;
                PlayerManager.Health = 100;
            }
        if (other.gameObject.tag == "Player")
        {
            PlayerManager.Health += 15;
            GameLevel += 1;
            SceneManager.LoadScene(1);
            RoomTemplates.spawnedBoss = false;
            RoomTemplates.waitTime = 5;
          
        }

    }
}
