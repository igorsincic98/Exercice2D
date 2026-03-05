using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public GameObject nextLevelUI;
    
    private bool _gameIsPaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameIsPaused = false;
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_gameIsPaused == false)
            {
                Pause();
            }
            else
            {
                Play();
            }
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
        _gameIsPaused = true;
        Time.timeScale = 0;
    }

    public void Play()
    {
        _gameIsPaused = false;
        Time.timeScale = 1;
    }

}
