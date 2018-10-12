using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text timerText;

    private bool isRunning = false;

    public float secondsRemaining { get; set; }

	// Use this for initialization.
	void Start ()
    {
        // Testing.
        StartTimer(120);

	}

    // Starts the game timer.
    public void StartTimer(float timeLimit)
    {
        // Set the initial timer values.
        secondsRemaining = timeLimit;
        timerText.text = ((int)secondsRemaining).ToString();
        isRunning = true;
    }

	// Update is called once per frame.
	void Update ()
    {
        if (isRunning)
        {
            secondsRemaining -= Time.deltaTime;
            timerText.text = MinuteSecond((int)secondsRemaining);
        }
	}

    // Convert seconds to minute-second format
    private string MinuteSecond (int totalSeconds)
    {
        // Break total seconds into components.
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        // Add seperator.
        string returnString = minutes + ":";

        // Add seconds with additional leading zero if neccasary.
        if (seconds < 10)
        {
            returnString += "0" + seconds;
        }
        else
        {
            returnString += seconds;
        }

        return returnString;
    }
}
