using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private float _timer = 0f;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameObject _portal;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 10f)
        {
            _portal.SetActive(true);
        }

        int minutes = Mathf.FloorToInt(_timer / 60f);
        int seconds = Mathf.FloorToInt(_timer % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
