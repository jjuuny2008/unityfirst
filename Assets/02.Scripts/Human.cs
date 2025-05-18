using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    float age = 18.0f;
    string HumanName = "±ËπŒ¡ÿ";
    float lenth = 167.8f;
    float Killo = 63.0f;
    string From = "Korea";
    bool IsMan = true;

    float Eat(float killo) { return killo++; }
    float sleep(float age) { return age += 0.0027f; }
    bool ts(bool gender) { return !gender; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
