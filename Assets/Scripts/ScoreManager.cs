using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public int targetScore = 100;
    public string nextSceneName = "End";

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score updated: " + score);
        if (scoreText != null)
            scoreText.text = "Score: " + score.ToString();

        if (score >= targetScore)
        {
            SceneManager.LoadScene(nextSceneName); // ✅ ไปฉากใหม่
        }
    }
}