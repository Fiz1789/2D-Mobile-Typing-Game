using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public EnemyManager enemymanager;
    public Text MyScoreText;
    public int ScoreNum;


    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
    }

    void Update()
    {
        ScoreUpdate();
        GameFinish();
    }

    // Update is called once per frame
    public void ScoreUpdate()
    {
        Debug.Log(enemymanager.enemyRespawn);
        if (enemymanager.enemyRespawn==true)
        {
            Debug.Log("Score Test");
            ScoreNum += 1;
            enemymanager.enemyRespawn = false;
        }

        MyScoreText.text = "Score: " + ScoreNum;
    }

    public void GameFinish()
    {
        if (ScoreNum == 3)
        {
            // Hide the keyboard once we finish the game
            MobileKeyboardManager.Instance.SetKeyboardVisibility(false);
            gameOverScreen.Setup();
        }
    }
}
