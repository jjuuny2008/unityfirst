using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animal
{
    public void Eat()
    {
        Debug.Log("������ ������ �Դ´�");
    }
 
}

public interface IMovable
{
    void Move();
}
