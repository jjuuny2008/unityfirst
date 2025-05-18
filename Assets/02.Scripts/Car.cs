using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update

    public string carSerise = "Volvo";
    public int accidentCount = 2147483647;
    public bool auto = false;


    public void CarGo()
    {
        Debug.Log("ºÎ¸ªºÎ¸ª~");
    }

    public void CarStop()
    {
        Debug.Log("³¢ÀÌÀÍ..");
    }

    public void CarAccident()
    {
        Debug.Log("Äâ¾Ó!!!");
        accidentCount++;
    }

    public void CarAutodrive()
    {
        Debug.Log("ÀÚÀ²ÁÖÇàÀ¸·Î ÇÕ´Ï´Ù.");
        auto = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
