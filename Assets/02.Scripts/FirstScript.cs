using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update


    public FirstScript() {
        Debug.Log("Constructer");
    }


    public int thisYear=2025;
    public float pi = 3.14f;
    public string myName = "±ËπŒ¡ÿ";
    public bool isGameOver = false;

    void Start()
    {       
        Debug.Log(thisYear);

        Debug.Log(pi);

        Debug.Log(myName);

        Debug.Log(isGameOver);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
