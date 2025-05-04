using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update


    float hp = 90.0f;
    float incomeDamage = 100.0f;
    bool IsGameOver = false;

    void Start()
    {
        hp -= incomeDamage;
        Debug.Log(hp);
        if (hp < 0)
        {
            IsGameOver = true;
        }
        if (IsGameOver)
        {
            Debug.Log("게임 오버");
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
