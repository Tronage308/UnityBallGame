using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public string LevelToLoad;

        public void LoadLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(LevelToLoad);

    }
}
