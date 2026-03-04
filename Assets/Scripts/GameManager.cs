using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public GameObject nextLevelUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameOverUI.activeInHierarchy) || (nextLevelUI.activeInHierarchy))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void _gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void _restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Play();
    }

    public void _nextLevel()
    {
        nextLevelUI.SetActive(true);
    }

    public void _loadLevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Play();
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
    }

}
