using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePotion : Potion
{
    public override void FillHP()
    {
        Debug.Log("중간hp 충전");
    }
}
