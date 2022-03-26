using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManger1 : MonoBehaviour
{
    public static float playerHealth, currentScore;
    public Image healthImg;
    public TMP_Text scoreText, highScoreText;
    public GameObject gameON, gameOFF, enemies, Level1, Level2, Level3, teleportTO;
    
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "High Score = " + PlayerPrefs.GetFloat("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0)
        {
           GameOver();
        }
        healthImg.fillAmount = playerHealth;
        scoreText.text = currentScore.ToString();
        if (currentScore == 500)
        {
            Level1.SetActive(false);
            Level2.SetActive(true);
            Level3.SetActive(false);
            currentScore += 100;

        }


    }

    public void GameStart()
    {
        gameON.SetActive(true);
        gameOFF.SetActive(false);
        playerHealth = 1;
        currentScore = 0;
        scoreText.text ="0";

    }

    public void GameOver()
    {
        if (currentScore > PlayerPrefs.GetFloat("HighScore"))
        {
        PlayerPrefs.SetFloat("HighScore",currentScore);
        highScoreText.text = "High Score = " + PlayerPrefs.GetFloat("HighScore").ToString();
        }
        foreach(Transform child in enemies.transform)
            child.gameObject.GetComponent<EnemyControler>().Death();

        transform.position = teleportTO.transform.position;
        Level1.SetActive(true);
        Level2.SetActive(false);
        Level3.SetActive(false);

        gameON.SetActive(false);
        gameOFF.SetActive(true);

    }
}
