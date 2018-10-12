using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class CharacterControl : MonoBehaviour
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

        // 
        Quaternion lockRotaion = this.transform.rotation;
        lockRotaion.z = 0;

        //
        this.transform.rotation = lockRotaion;

        switch (playerNum)
        {

            case PlayerNumber.PLAYER_ONE:
                {

                    float xInput = Input.GetAxis("Player1MoveX");
                    float yInput = Input.GetAxis("Player1MoveY");

                    this.transform.position += new Vector3(xInput, yInput, 0) * characterSpeed  * Time.deltaTime;

                    if (Input.GetAxis("DropPancake1") != 0)
                    {

                        Debug.Log("P1");

                    }

                    if ((int)Input.GetAxis("Interact1") != 0)
                    {



                    }

                    break;
                }
            case PlayerNumber.PLAYER_TWO:
                {

                    float xInput = Input.GetAxis("Player2MoveX");
                    float yInput = Input.GetAxis("Player2MoveY");

                    this.transform.position += new Vector3(xInput, yInput, 0) * characterSpeed * Time.deltaTime;

                    if (Input.GetAxis("DropPancake2") != 0)
                    {

                        Debug.Log("P2");

                    }

                    if ((int)Input.GetAxis("Interact2") != 0)
                    {



                    }

                    break;
                }

        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        switch(collision.gameObject.tag)
        {

            case "Pancake":
                {

                    

                    break;
                }

        }

    }

}
