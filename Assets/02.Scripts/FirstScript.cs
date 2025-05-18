using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;









public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update




    void Start()
    {
        int a = 5;

        int b = a;

        b = 10;
        Debug.Log(a);
        Debug.Log(b);
    }

   


    // Update is called once per frame
    void Update()
    {
       

    }
}
