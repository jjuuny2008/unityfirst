using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public float age = 18.0f;
    public string humanName = "±ËπŒ¡ÿ";
    public float height = 167.8f;
    public float weight = 63.0f;
    public string countury = "Korea";
    public bool isMan = true;

    public float Eat(float killo) { return killo++; }
    public float sleep(float age) { return age += 0.0027f; }
    public bool Ts(bool gender) { return !gender; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
