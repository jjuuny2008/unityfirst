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
        Debug.Log("�θ��θ�~");
    }

    public void CarStop()
    {
        Debug.Log("������..");
    }

    public void CarAccident()
    {
        Debug.Log("���!!!");
        accidentCount++;
    }

    public void CarAutodrive()
    {
        Debug.Log("������������ �մϴ�.");
        auto = true;
    }

    public void CarLeft()
    {
        Debug.Log("����");
    }
    public void CarRight()
    {
        Debug.Log("������");
    }
    public void CarForward()
    {
        Debug.Log("����");
    }
    public void CarBackward()
    {
        Debug.Log("����");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
