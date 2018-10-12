using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Timer : MonoBehaviour
{
    [Header("Text Element")]
    [SerializeField]
    private Text timerText;

    // Timer colors.
    [Header("Colors")]
    [SerializeField]
    private Color timerColor;
    [SerializeField]
    private Color lastThirtySecColor;
    [SerializeField]
    private Color lastTenSecColor;

    // Time pulse.
    [Header("Animation (optional)")]
    [SerializeField]
    private Animator pulse;

    // Testing
    [Header("Testing")]
    [SerializeField]
    private bool test;
    [SerializeField]
    private int seconds;

    private bool isRunning = false;

    private int lastDecrement;

    public float secondsRemaining { get; set; }

	// Use this for initialization.
	void Start ()
    {
        // Testing.
        if (test)
        {
            StartTimer(seconds);
        }
    }

    // Starts the game timer.
    public void StartTimer(float timeLimit)
    {
        // Set the initial timer values.
        lastDecrement = (int)timeLimit;
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

            if ((int)secondsRemaining != lastDecrement)
            {
                lastDecrement--;
                timerText.text = MinuteSecond((int)secondsRemaining);

                if (secondsRemaining > 30)
                {
                    timerText.color = timerColor;
                }
                else if (secondsRemaining > 10)
                {
                    timerText.color = lastThirtySecColor;
                }
                else
                {
                    timerText.color = lastTenSecColor;
                    if (pulse != null)
                    {
                        pulse.Play("PulsateTimer");
                    }
                }
            }
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
