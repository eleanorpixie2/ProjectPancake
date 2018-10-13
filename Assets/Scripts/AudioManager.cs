using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField]
    private Timer gameTimer;

    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioSource source2;

    [SerializeField]
    private AudioClip menu;
    [SerializeField]
    private AudioClip menuTransition;
    [SerializeField]
    private AudioClip gameMusic;
    [SerializeField]
    private AudioClip countdown;
    [SerializeField]
    private AudioClip victory;


    private bool inMenuTransition = false;
    private float menuTransitionStartTime;

    private bool menuTransition1 = false;

    private bool inGameEndTransition = false;
    private float endGameTransitionStartTime;

    private bool inMenu = true;

    public void PlayMenu()
    {
        inMenu = true;
        source.clip = menu;
        source.Play();
        source2.Stop();
    }
    public void PlayGame(Timer timerGame)
    {
        inMenuTransition = true;
        menuTransition1 = false;
        menuTransitionStartTime = Time.time;
        source2.clip = menuTransition;
        source2.Play();
    }



    // Use this for initialization
    void Start()
    {
        PlayMenu();
    }

    // Update is called once per frame
    void Update()
    {

        if (inMenu)
        {

        }
        else
        {
            if (inMenuTransition)
            {
                if (!menuTransition1)
                {
                    if (Time.time - menuTransitionStartTime > 2.3684f)
                    {
                        menuTransition1 = true;
                        source.clip = gameMusic;
                        source.volume = 1;
                        source.Play();
                    }
                    else if (Time.time - menuTransitionStartTime < 1)
                    {
                        float clipOneVolume = Mathf.Pow(1 - (Time.time - menuTransitionStartTime), 2);
                        source.volume = clipOneVolume;
                    }
                    else
                    {
                        source.volume = 0;
                    }
                }
                else
                {
                    if (Time.time - menuTransitionStartTime > 5.526f)
                    {
                        inMenuTransition = false;
                        source2.clip = countdown;

                        source2.Play();

                        source2.volume = 0;
                    }
                }
            }
            else if (inGameEndTransition)
            {
                if (Time.time - endGameTransitionStartTime < 1)
                {
                    float clipTwoVolume = Mathf.Pow(1 - (Time.time - endGameTransitionStartTime), 2);
                    source2.volume = clipTwoVolume;
                }

                if (Time.time - endGameTransitionStartTime > 6)
                {
                    source.Stop();
                }
            }
            else
            {
                if (gameTimer.secondsRemaining > 60)
                {
                    source.volume = 1;
                    source2.volume = 0;
                }
                else if (gameTimer.secondsRemaining > 52.5f)
                {
                    float clipOneVolume = Mathf.Pow(((gameTimer.secondsRemaining - 52.5f) / 7.5f), 2);
                    float clipTwoVolume = Mathf.Pow(1 - ((gameTimer.secondsRemaining - 52.5f) / 7.5f), 2);

                    source.volume = clipOneVolume;
                    source2.volume = clipTwoVolume;
                }
                else if (gameTimer.secondsRemaining > 1)
                {
                    source.volume = 0;
                    source2.volume = 1;
                }
                else
                {
                    endGameTransitionStartTime = Time.time;
                    source.clip = victory;
                    source.volume = 1;
                    source.Play();
                    inGameEndTransition = true;
                }
            }
        }
    }
}
