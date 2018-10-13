using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {


    [SerializeField]
    private Timer gameTimer;


    [SerializeField]
    private AudioSource source;

    [SerializeField]
    private AudioClip countdown;
    [SerializeField]
    private AudioClip gameMusic;


	// Use this for initialization
	void Start () {
        source.clip = countdown;
        source.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
