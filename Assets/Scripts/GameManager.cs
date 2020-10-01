using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverPanel;
    private bool gameOver = false;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        FindObjectOfType<PlayerCollision>().OnPlayerDeath += GameOver;
    }


    // Update is called once per frame
    void Update()
    {
        if (gameOver) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                RestartGame();
            }
        }
    }

    
    private void RestartGame() {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void GameOver() {
        gameOverPanel.SetActive(true);
        gameOver = true;
        scoreText.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
    }

}
