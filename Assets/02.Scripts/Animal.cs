using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public string Name { get; set; }
    public virtual void Speak()
    {
        Debug.Log("Animal makes a sound");
    }
 
}
