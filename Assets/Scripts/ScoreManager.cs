using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void AddScore(int amount)
    {
        score += amount;
        UpdateText();

    }
    void UpdateText()
    {
        scoreText.text = "Score: " + score;
    }
}
