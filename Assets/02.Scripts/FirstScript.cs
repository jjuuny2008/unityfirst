using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;



enum state
{
    None,
    WARNING,
    DANGER,
    DEAD
}

enum Fruit
{
    Apple,
    Banana,
    Peach,
    Orange
}



public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update


    float hp = 100.0f;
    float incomeDamage = 20.0f;
    state state=state.None;
    Fruit Fruit = Fruit.Apple;

    void Start()
    {
        Debug.Log("Game Started");

    }

    // Update is called once per frame
    void Update()
    {
        if(hp<=60)
        {
            state = state.WARNING;
        }
        if (hp <= 40)
        {
            state = state.DANGER;
        }
        if (hp <= 0)
        {
            state = state.DEAD;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp -= incomeDamage;

            switch (state)
            {
                case state.DEAD:
                    Debug.Log("GameOver");
                    break;
                case state.WARNING:
                    Debug.Log("Emenrgency!!");
                    break
            ;   case state.DANGER:
                    Debug.Log("Watch out");
                    break;
                default:
                    Debug.Log("Current Health is " + hp);
                    break;

            }
            
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            switch (Fruit)
            {
                case Fruit.Apple:
                    Debug.Log("Apple is yammy");
                    Fruit = Fruit.Banana;
                    break;
                case Fruit.Banana:
                    Debug.Log("Banana is yammy");
                    Fruit = Fruit.Peach;
                    break;
                case Fruit.Peach:
                    Debug.Log("Peach is yammy");
                    Fruit = Fruit.Orange;
                    break;
                case Fruit.Orange:
                    Debug.Log("Orange is yammy");
                    Fruit = Fruit.Apple;
                    break;
            }
        }

    }
}
