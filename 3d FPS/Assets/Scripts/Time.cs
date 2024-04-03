using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class Time : MonoBehaviour
{
    public float timeRemaining = 60f;
    public TextMeshProUGUI timerText;
    private bool _isTimerRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_isTimerRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayGameTimer(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                _isTimerRunning = false;
            }
        }
    }

    public void StartGameTimer()
    {
        _isTimerRunning = true;
    }

    private void EndGameTimer()
    {
        _isTimerRunning = false;
    }

    private void DisplayGameTimer(float timeToDisplay)
    {
        timeRemaining += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    }
}
