using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;









public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update

    float NextYear(int thisyear)
    {
        return thisyear + 1;
    }
    void Start()
    {
        Debug.Log(plusnum(1));
        Debug.Log(plusnum(3, 2));
        
    }

    int plusnum(int a) {  return a +8; }
    int plusnum(int a, int b) { return a +b; }


    // Update is called once per frame
    void Update()
    {
       

    }
}
