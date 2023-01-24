using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;

    public bool gamePause = false;
    public int pointGame;

    private void Awake()
    {
        ins = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.currentHp == 0 )
        {
            Death();
        }
    }

    void Death()
    {
        gamePause = true;
        UIManager.ins._gameOverPanel.SetActive(true);
    }
}
