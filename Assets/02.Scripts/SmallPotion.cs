using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPotion : Potion
{
    public override void FillHP()
    {
        Debug.Log("적게hp 충전");
    }
}
