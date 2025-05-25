using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal, IMovable
{

    public void Move()
    {
        Debug.Log("고양이가 빠르게 뛰어간다");
    }
}

