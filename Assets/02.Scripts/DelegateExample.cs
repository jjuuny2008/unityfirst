using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    public delegate void MyDelegate(string message);

    void PrintMessage(string message)
    {
        Debug.Log("프린트 : "+message);
    }

    void WarningMessage(string message)
    {
        Debug.Log("경고 : " + message);
    }

    void LogMessage(string message)
    {
        Debug.Log("로그 : "+message);
    }

    void DangerMessage(string message)
    {
        Debug.Log("위험 : " + message);
    }
    // Start is called before the first frame update
    void Start()
    {
        MyDelegate myDelegate = PrintMessage;
        myDelegate += DangerMessage;
        myDelegate += WarningMessage;
        myDelegate("Hello World!");
        myDelegate -= DangerMessage;
        myDelegate -= WarningMessage;
        myDelegate("Hello World!");
    }

    
}
