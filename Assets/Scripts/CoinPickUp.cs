using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public int score = 1;
    private ScoreManager scoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        scoreManager.AddScore(score);
        Destroy(gameObject);

    }

}
