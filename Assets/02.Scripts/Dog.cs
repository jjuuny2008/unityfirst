using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal, IMovable
{
    public void Move()
    {
        Debug.Log("���� ������ �پ��");
    }
}
