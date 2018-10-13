using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {


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

    private bool inGameEndTransition = false;
    private float endGameTransitionStartTime;

    public void PlayMenu ()
    {
        source.clip = menu;
        source.Play();
        source2.Stop();
    }
    public void PlayGame()
    {
        inMenuTransition = true;
        menuTransitionStartTime = Time.time;
        source2.clip = menuTransition;
        source2.Play();
    }



    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (inMenuTransition)
        {
            float clipOneVolume = Mathf.Pow(1 - (Time.time - menuTransitionStartTime), 2);
            source.volume = clipOneVolume;
            if (Time.time - menuTransitionStartTime > 2.3684f)
            {
                inMenuTransition = false;
                source.clip = gameMusic;
                source2.clip = countdown;

                source.volume = 1;
                source2.volume = 0;
            }
        }
        else if (inGameEndTransition)
        {
            float clipTwoVolume = Mathf.Pow(1 - (Time.time - endGameTransitionStartTime), 2);
            source2.volume = clipTwoVolume;
        }
        else
        {
            if (gameTimer.secondsRemaining > 60)
            {
                source.volume = 1;
                source2.volume = 0;
            }
            else if (gameTimer.secondsRemaining > 50)
            {
                float clipOneVolume = Mathf.Pow(((gameTimer.secondsRemaining - 50) / 10), 2);
                float clipTwoVolume = Mathf.Pow(1 - ((gameTimer.secondsRemaining - 50) / 10), 2);

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
                source.loop = false;
                inGameEndTransition = true;
            }
        }
	}
}
