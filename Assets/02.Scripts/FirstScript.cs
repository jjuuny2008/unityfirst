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
        for (int i =0; i<names.Count;i++) 
        {
            Debug.Log(names[i]);
        }



    }
        // Update is called once per frame
        void Update()
    {
       

    }
}
