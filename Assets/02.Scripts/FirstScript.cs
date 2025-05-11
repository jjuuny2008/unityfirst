using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;









public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update




    void EnemyAttack()
    {
        Debug.Log("Enemy Attack");
        Debug.Log("Enemy Damage");
        Debug.Log("Enemy HP UI Update");
    }

    int thisyear()
    {
        return 2025;
    }

    float NextYear()
    {
        return thisyear() + 1;
    }
    void Start()
    {
        Debug.Log(NextYear());

    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
