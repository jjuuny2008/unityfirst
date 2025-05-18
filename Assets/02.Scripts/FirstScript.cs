using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;









public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update

    List<string> names = new List<string>() { "Alice", "Bob", "Chalie" };


    void Start()
    {
        foreach (string name in names) 
        {
            Debug.Log(name);
        }



    }
        // Update is called once per frame
        void Update()
    {
       

    }
}
