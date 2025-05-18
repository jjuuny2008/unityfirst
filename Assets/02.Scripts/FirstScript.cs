using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;









public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update


    public List<int> myList = new List<int>();
    public List<int> myList2 = new List<int>() {4,5,9 };


    void Start()
    {
        myList.Add(5);
        myList.Add(10);

        myList.Insert(1, 7);

        myList.Add(15);

        myList.Remove(5);

        myList.RemoveAt(1);

    }

   


    // Update is called once per frame
    void Update()
    {
       

    }
}
