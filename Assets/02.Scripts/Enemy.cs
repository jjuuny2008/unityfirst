using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
      
    public virtual void Die()
    {
        Debug.Log("적이 죽었습니다.");
    }
}
