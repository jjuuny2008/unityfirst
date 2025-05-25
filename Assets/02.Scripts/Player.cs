using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Weapon myWeapon;

    private void Start()
    {
        myWeapon = new TwoHandSword();
        myWeapon.Attack();

        myWeapon = new Shortbow();
        myWeapon.Attack();
    }
}
