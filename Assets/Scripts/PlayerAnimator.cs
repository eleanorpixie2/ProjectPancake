using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    // Animators.
    [SerializeField]
    private Animator player1;
    [SerializeField]
    private Animator player2;
	
	// Update is called once per frame.
	void Update ()
    {
        // Animate player 1.
        if (!player1.gameObject.GetComponent<CharacterControl>().isMoving)
        {

            switch (player1.gameObject.GetComponent<CharacterControl>()._playerDirection)
            {
                case PlayerDirection.DOWN:
                    player1.Play("Idle Down");
                    Debug.Log("1 down");
                    break;
                case PlayerDirection.LEFT:
                    player1.Play("Idle Left");
                    Debug.Log("1 left");
                    break;
                case PlayerDirection.RIGHT:
                    player1.Play("Idle Right");
                    Debug.Log("1 right");
                    break;
                case PlayerDirection.UP:
                    player1.Play("Idle Up");
                    Debug.Log("1 up");
                    break;
            }

        }
        else
        {
            switch (player1.gameObject.GetComponent<CharacterControl>()._playerDirection)
            {
                case PlayerDirection.DOWN:
                    player1.Play("WalkingSouth");
                    Debug.Log("1 down");
                    break;
                case PlayerDirection.LEFT:
                    player1.Play("WalkingWest");
                    Debug.Log("1 left");
                    break;
                case PlayerDirection.RIGHT:
                    player1.Play("WalkingEast");
                    Debug.Log("1 right");
                    break;
                case PlayerDirection.UP:
                    player1.Play("WalkingNorth");
                    Debug.Log("1 up");
                    break;
            }
        }

        // Animate player 2.
        if (!player2.gameObject.GetComponent<CharacterControl>().isMoving)
        {
            switch (player2.gameObject.GetComponent<CharacterControl>()._playerDirection)
            {
                case PlayerDirection.DOWN:
                    player2.Play("Idle Down");
                    Debug.Log("1 down");
                    break;
                case PlayerDirection.LEFT:
                    player2.Play("Idle Left");
                    Debug.Log("1 left");
                    break;
                case PlayerDirection.RIGHT:
                    player2.Play("Idle Right");
                    Debug.Log("1 right");
                    break;
                case PlayerDirection.UP:
                    player2.Play("Idle Up");
                    Debug.Log("1 up");
                    break;
            }
        }
        else
        {
            switch (player2.gameObject.GetComponent<CharacterControl>()._playerDirection)
            {
                case Assets.Scripts.PlayerDirection.DOWN:
                    player2.Play("WalkingSouth");
                    break;
                case Assets.Scripts.PlayerDirection.LEFT:
                    player2.Play("WalkingWest");
                    break;
                case Assets.Scripts.PlayerDirection.RIGHT:
                    player2.Play("WalkingEast");
                    break;
                case Assets.Scripts.PlayerDirection.UP:
                    player2.Play("WalkingNorth");
                    break;
            }
        }
    }
}
