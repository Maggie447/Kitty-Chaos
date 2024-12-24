using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI livesText;
    public Button startButton;
    public Button restartButton;
    public GameObject titleScreen;
    public bool isGameActive;
    private int lives;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Dog"))
        {
            UpdateLives();
        }
    }

    public void UpdateLives()
    {
        if (isGameActive)
        {
            lives--;
            livesText.text = "Lives: " + lives;
            if (lives == 0)
            {
                GameOver();
            }
        }
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        isGameActive = true;
        lives = 9;
        titleScreen.gameObject.SetActive(false);
        livesText.text = "Lives: " + lives;
    }
}
