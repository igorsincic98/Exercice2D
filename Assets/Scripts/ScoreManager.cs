using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject PickUp;
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private string _scoreString;

    public int Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        ShowScore();
    }

    void ShowScore()
    {
        _scoreString = Score.ToString();
        
        // formatter pour que _scoreString ait 5 caractères
        int scoreLength = 5 - _scoreString.Length;

        int i = 0;
        while (i < scoreLength)
        {
            _scoreString = "0" +  _scoreString;
            i++;
        }
        
        scoreText.text = _scoreString;
    }

    public void AddPointPickUp()
    {
        Score += 50;
        ShowScore();
    }
}
