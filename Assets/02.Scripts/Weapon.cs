using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    public string Name { get; set; }

    public virtual void Attack()
    {
        Debug.Log("Weapon Attacks!");
    }
}
    // Start is called before the first frame update

