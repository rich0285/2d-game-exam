using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private int Health = 100;
    public Text HealthText;


    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = "Health : " + Health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Set Hp

    }
}
