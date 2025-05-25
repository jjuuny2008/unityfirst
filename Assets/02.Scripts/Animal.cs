using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animal
{
    public void Eat()
    {
        Debug.Log("동물이 음식을 먹는다");
    }
 
}

public interface IMovable
{
    void Move();
}
