using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class CharacterControl : MonoBehaviour
{

    [SerializeField]
    PlayerNumber playerNumber;

    [SerializeField]
    PlayerDirection playerDirection;

    [SerializeField]
    GameObject heldItem;

    [SerializeField]
    float characterSpeed;

    public PlayerDirection _playerDirection { get { return playerDirection; } }

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
        RotateCharacter();

        if (heldItem != null)
        {

            MoveHeldItem();

        }

    }

    void InputHandler()
    {

        switch (playerNumber)
        {

            case PlayerNumber.PLAYER_ONE:
                {

                    float xInput = Input.GetAxis("Player1MoveX");
                    float yInput = Input.GetAxis("Player1MoveY");

                    this.transform.position += new Vector3(xInput, yInput, 0) * characterSpeed  * Time.deltaTime;

                    if (xInput < 0)
                    {

                        playerDirection = PlayerDirection.LEFT;

                    }
                    if (xInput > 0)
                    {

                        playerDirection = PlayerDirection.RIGHT;

                    }
                    if (yInput < 0)
                    {

                        playerDirection = PlayerDirection.DOWN;

                    }
                    if (yInput > 0)
                    {

                        playerDirection = PlayerDirection.UP;

                    }

                    if (Input.GetButtonDown("DropPancake1") && heldItem != null)
                    {

                        heldItem = null;

                    }

                    break;
                }
            case PlayerNumber.PLAYER_TWO:
                {

                    float xInput = Input.GetAxis("Player2MoveX");
                    float yInput = Input.GetAxis("Player2MoveY");

                    this.transform.position += new Vector3(xInput, yInput, 0) * characterSpeed * Time.deltaTime;

                    if (xInput < 0)
                    {

                        playerDirection = PlayerDirection.LEFT;

                    }
                    if (xInput > 0)
                    {

                        playerDirection = PlayerDirection.RIGHT;

                    }
                    if (yInput < 0)
                    {

                        playerDirection = PlayerDirection.DOWN;

                    }
                    if (yInput > 0)
                    {

                        playerDirection = PlayerDirection.UP;

                    }

                    if (Input.GetButtonDown("DropPancake2") && heldItem != null)
                    {

                        heldItem = null;

                    }

                    break;
                }

        }

    }

    void MoveHeldItem()
    {

        heldItem.transform.position = this.transform.position;
        switch (playerDirection)
        {

            case PlayerDirection.UP:
                {

                    heldItem.transform.position += new Vector3(0, 1, 0);
                    break;
                }
            case PlayerDirection.DOWN:
                {

                    heldItem.transform.position += new Vector3(0, -1, 0);
                    break;
                }
            case PlayerDirection.LEFT:
                {

                    heldItem.transform.position += new Vector3(-1, 0, 0);
                    break;
                }
            case PlayerDirection.RIGHT:
                {

                    heldItem.transform.position += new Vector3(1, 0, 0);
                    break;
                }

        }

    }

    void RotateCharacter()
    {

        switch(playerDirection)
        {

            case PlayerDirection.UP:
                {


                    break;
                }
            case PlayerDirection.DOWN:
                {

                    break;
                }
            case PlayerDirection.LEFT:
                {

                    break;
                }
            case PlayerDirection.RIGHT:
                {

                    break;
                }
        
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("test1");
        //switch (collision.gameObject.tag)
        //{
        Debug.Log(Input.GetButtonDown("DropPancake1"));

        if (collision.gameObject.tag == "Pancake")
        {

            if (Input.GetButtonDown("DropPancake1"))
            {

                Debug.Log(Input.GetButtonDown("DropPancake1"));
                heldItem = collision.gameObject;

            }
            //if (Input.GetButtonDown("DropPancake2") &&
            //    playerNumber == PlayerNumber.PLAYER_TWO &&
            //    heldItem == null)
            //{

            //    heldItem = collision.gameObject;

            //}
            //break;
        }

        

    }

}
