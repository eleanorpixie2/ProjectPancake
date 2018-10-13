using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RF_CollisionManager : MonoBehaviour
{


    [SerializeField]
    int playerNum;

    CharacterControl Player;


    // Use this for initialization
    void Start ()
    {

        Player = this.gameObject.GetComponent<CharacterControl>();

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

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.BLUBERRIES))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.BLUBERRIES);

                    }

                    break;
                }
            case "Syrup":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.SYRUP))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.SYRUP);

                    }
                    break;
                }
            case "Nuts":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.PECANS))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.PECANS);

                    }
                    break;
                }
            case "ChocoChips":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.CHOC_CHIPS))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.CHOC_CHIPS);

                    }
                    break;
                }
            case "Whipcream":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.WHIPCREAM))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.WHIPCREAM);

                    }
                    break;
                }

        }

    }

}
