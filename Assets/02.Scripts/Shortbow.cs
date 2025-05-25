using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shortbow : Weapon
{
    public override void Attack()
    {
        Debug.Log("이게 기관총인지 활인지, 아무리 숏보우라곤 하지만 난사 속도가 너무 빠른거 아닙니까?");
    }
}
