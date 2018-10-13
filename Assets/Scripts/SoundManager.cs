using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SoundManager : MonoBehaviour
{


    [SerializeField]
    float ShowTime;
    Timer TestTimer;

    [SerializeField]
    CharacterControl Player1;
    [SerializeField]
    CharacterControl Player2;

    // Use this for initialization
    void Start ()
    {

        //if (TestTimer == null)
        //{

        //    TestTimer = this.gameObject.GetComponent<Timer>();

        //}

        //TestTimer.StartTimer(10);

	}

    // Update is called once per frame
    void Update()
    {


        //ShowTime = TestTimer.secondsRemaining;


    }

}

