using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;









public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update



    void Start()
    {
        Potion Potion = new SmallPotion();
        Potion.FillHP();

        Potion = new MiddlePotion();
        Potion.FillHP();

        Potion = new LargePotion();
        Potion.FillHP(); 

   
    }
}
