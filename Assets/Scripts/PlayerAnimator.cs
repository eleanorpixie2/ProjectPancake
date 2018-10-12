using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    // Animators.
    [SerializeField]
    private Animator player1;
    [SerializeField]
    private Animator player2;
	
	// Update is called once per frame
	void Update ()
    {
        if (player1.gameObject.GetComponent<CharacterControl>().isMoving) // Player is idle.
        {
            player1.Play("Idle");
        }
        else
        {
            switch (player1.gameObject.GetComponent<CharacterControl>()._playerDirection)
            {
                case Assets.Scripts.PlayerDirection.DOWN:
                    player1.Play("WalkingSouth");
                    break;
                case Assets.Scripts.PlayerDirection.LEFT:
                    player1.Play("WalkingWest");
                    break;
                case Assets.Scripts.PlayerDirection.RIGHT:
                    player1.Play("WalkingEast");
                    break;
                case Assets.Scripts.PlayerDirection.UP:
                    player1.Play("WalkingNorth");
                    break;
            }
        }

        if (player2.gameObject.GetComponent<CharacterControl>().isMoving) // Player2 is idle.
        {
            player2.Play("Idle");
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
