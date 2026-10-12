using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winPanel;
    private void OnTriggerEnter(Collider other)
    {
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}