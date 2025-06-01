using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    public delegate void MyDelegate(string message);

    void PrintMessage(string message)
    {
        Debug.Log("����Ʈ : "+message);
    }

    void WarningMessage(string message)
    {
        Debug.Log("��� : " + message);
    }

    void LogMessage(string message)
    {
        Debug.Log("�α� : "+message);
    }

    void DangerMessage(string message)
    {
        Debug.Log("���� : " + message);
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
