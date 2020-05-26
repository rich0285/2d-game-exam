using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Score;
    public Text ScoreText;
    public Text HealthText;
    public float Health;
  

    void Update()
    {
        ScoreManager();
        HealthManager();
       

    }



    void ScoreManager()
    {
        Score = PlayerManager.Score;
        ScoreText.text = "Score: " + Score;
    }

    void HealthManager()
    {
        Health = PlayerManager.Health;

        HealthText.text = "Health : " + Health;
    }
}
