using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private void OnEnable()
    {
        PlayerController.OnGameOver += RespondToGameOver;
    }

    private void OnDisable()
    {
        PlayerController.OnGameOver -= RespondToGameOver;
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RespondToGameOver()
    {
        Debug.Log("EnemyController : �÷��̾� ���, �ٽ� ���� Patrol�� ��ȯ");
        OnDisable();
    }
}
