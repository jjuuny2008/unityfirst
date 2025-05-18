using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Kimminjun : Human
{
    // Start is called before the first frame update
    void Start()
    {
        Eat(age);
        Debug.Log(age);   
        Debug.Log(humanName);
    }

}
