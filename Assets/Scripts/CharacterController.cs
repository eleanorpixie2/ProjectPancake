using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class CharacterController : MonoBehaviour
{

    [SerializeField]
    PlayerNumber playerNum;

    [SerializeField]
    float characterSpeed;

    //
    Rigidbody2D thisRigidBody;

	// Use this for initialization
	void Start ()
    {

        thisRigidBody = this.gameObject.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update ()
    {

        InputHandler();

	}

    void InputHandler()
    {

        switch(playerNum)
        {

            case PlayerNumber.PLAYER_ONE:
                {

                    float xInput = Input.GetAxis("Player1MoveX");
                    float yInput = Input.GetAxis("Player1MoveY");

                    this.transform.position += new Vector3(xInput, yInput, 0) * characterSpeed  * Time.deltaTime;
                    Debug.Log(new Vector3(xInput, yInput, 0) * characterSpeed * Time.deltaTime);

                    break;
                }
            case PlayerNumber.PLAYER_TWO:
                {

                    float xInput = Input.GetAxis("Player2MoveX");
                    float yInput = Input.GetAxis("Player2MoveY");

                    thisRigidBody.AddForce(new Vector2(xInput, yInput));

                    break;
                }

        }

    }

}
