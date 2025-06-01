    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerController : MonoBehaviour
    {
        public delegate void GameOverEvent();
        public static event GameOverEvent OnGameOver;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Playercontroller : press 'G' to game over"); 

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                TriggerGameOver();
            }
        }
    void TriggerGameOver()
    {
        Debug.Log("GameOver");
        if (OnGameOver != null)
        {
            OnGameOver();
        }
    }
}

