using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RF_CollisionManager : MonoBehaviour
{

    [SerializeField]
    CharacterControl Player1;

    [SerializeField]
    CharacterControl Player2;

    [SerializeField]
    int playerNum;

    // Use this for initialization
    void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        switch(collision.gameObject.tag)
        {

            case "Blueberries":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0)
                    {

                        PlayerCheck(playerNum).heldPancake.AddTopping(PancakeToppings.BLUBERRIES);

                    }

                    break;
                }
            case "Syrup":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0)
                    {

                        PlayerCheck(playerNum).heldPancake.AddTopping(PancakeToppings.SYRUP);

                    }
                    break;
                }
            case "Nuts":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0)
                    {

                        PlayerCheck(playerNum).heldPancake.AddTopping(PancakeToppings.PECANS);

                    }
                    break;
                }
            case "ChocoChips":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0)
                    {

                        PlayerCheck(playerNum).heldPancake.AddTopping(PancakeToppings.CHOC_CHIPS);

                    }
                    break;
                }
            case "Whipcream":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0)
                    {

                        PlayerCheck(playerNum).heldPancake.AddTopping(PancakeToppings.WHIPCREAM);

                    }
                    break;
                }

        }

    }

    CharacterControl PlayerCheck(int pNum)
    {

        if (pNum == 1)
        {

            return Player1;

        }
        else
        {

            return Player2;

        }

    }

}
