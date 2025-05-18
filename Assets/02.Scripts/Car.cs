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
        Debug.Log("부릉부릉~");
    }

    public void CarStop()
    {
        Debug.Log("끼이익..");
    }

    public void CarAccident()
    {
        Debug.Log("콰앙!!!");
        accidentCount++;
    }

    public void CarAutodrive()
    {
        Debug.Log("자율주행으로 합니다.");
        auto = true;
    }

    public void CarLeft()
    {
        Debug.Log("왼쪽");
    }
    public void CarRight()
    {
        Debug.Log("오른쪽");
    }
    public void CarForward()
    {
        Debug.Log("전진");
    }
    public void CarBackward()
    {
        Debug.Log("후진");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
