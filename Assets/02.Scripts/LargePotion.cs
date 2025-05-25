using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargePotion : Potion
{
    public override void FillHP()
    {
        Debug.Log("많이hp 충전");
    }
}
