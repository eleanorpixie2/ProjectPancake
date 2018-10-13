using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RF_CollisionManager : MonoBehaviour
{

    [SerializeField]
    RF_OrderManager orderManager;

    [SerializeField]
    OrderTracker orderTracker;

    [SerializeField]
    int playerNum;

    CharacterControl Player;
    public Animator bAnimator;
    public Animator sAnimator;
    public Animator wAnimator;
    public Animator cAnimator;
    public Animator nAnimator;

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
                        bAnimator.SetBool("hasBlueberries", true);

                    }

                    break;
                }
            case "Syrup":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.SYRUP))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.SYRUP);
                        sAnimator.SetBool("hasSyrup", true);

                    }
                    break;
                }
            case "Nuts":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.PECANS))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.PECANS);
                        nAnimator.SetBool("hasPecans",true);
                    }
                    break;
                }
            case "ChocoChips":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.CHOC_CHIPS))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.CHOC_CHIPS);
                        cAnimator.SetBool("hasChocChips", true);

                    }
                    break;
                }
            case "Whipcream":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.WHIPCREAM))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.WHIPCREAM);
                        wAnimator.SetBool("hasWhipCream",true);
                    }
                    break;
                }

                //
            case "Order1":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {
                        Debug.Log("test");
                        switch(playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order1")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }


                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order1")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }


                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }                 
                    }

                    break;
                }
            case "Order2":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {

                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order2")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }


                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order2")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }
 

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }

                    }
                    break;
                }
            case "Order3":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {

                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order3")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order3")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }
                    }
                    break;
                }
            case "Order4":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {

                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order4")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order4")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }

                    }
                    break;
                }
            case "Order5":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {

                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order5")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }

                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;

                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order5")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }
     
                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }
                    }
                    break;
                }


        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        switch (collision.gameObject.tag)
        {

            case "Blueberries":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.BLUBERRIES))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.BLUBERRIES);
                        bAnimator.SetBool("hasBlueberries", true);

                    }

                    break;
                }
            case "Syrup":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.SYRUP))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.SYRUP);
                        sAnimator.SetBool("hasSyrup", true);

                    }
                    break;
                }
            case "Nuts":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.PECANS))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.PECANS);
                        nAnimator.SetBool("hasPecans", true);
                    }
                    break;
                }
            case "ChocoChips":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.CHOC_CHIPS))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.CHOC_CHIPS);
                        cAnimator.SetBool("hasChocChips", true);

                    }
                    break;
                }
            case "Whipcream":
                {

                    if (Input.GetAxis("Topping" + playerNum) != 0 && Player.heldPancake != null && !Player.heldPancake.toppings.Contains(PancakeToppings.WHIPCREAM))
                    {

                        Player.heldPancake.AddTopping(PancakeToppings.WHIPCREAM);
                        wAnimator.SetBool("hasWhipCream", true);
                    }
                    break;
                }

            //
            case "Order1":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {
                        Debug.Log("test");
                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order1")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }


                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order1")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }


                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }
                    }

                    break;
                }
            case "Order2":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {

                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order2")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }


                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order2")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }


                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }

                    }
                    break;
                }
            case "Order3":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {

                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order3")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order3")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }
                    }
                    break;
                }
            case "Order4":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {

                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order4")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order4")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }

                    }
                    break;
                }
            case "Order5":
                {

                    if (Input.GetAxis("Interact" + playerNum) != 0 && Player.heldPancake != null)
                    {

                        switch (playerNum)
                        {
                            case 1:
                                {

                                    for (int i = 0; i < orderManager.blueOrderList.Count; i++)
                                    {

                                        if (orderManager.blueOrderList[i].name == "Order5")
                                        {

                                            bool pancakeCheck = orderManager.blueOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }

                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;

                                }
                            case 2:
                                {

                                    for (int i = 0; i < orderManager.redOrderList.Count; i++)
                                    {

                                        if (orderManager.redOrderList[i].name == "Order5")
                                        {

                                            bool pancakeCheck = orderManager.redOrderList[i].GetComponent<GameOrder>().thisOrder.CheckOrder(Player.heldPancake);
                                            if (pancakeCheck)
                                            {

                                                orderTracker.CompletedOrder(playerNum);

                                            }

                                        }

                                    }


                                    GameObject.Destroy(Player.heldItem);
                                    ResetAnimator();
                                    break;
                                }

                        }
                    }
                    break;
                }


        }

    }

    public void ResetAnimator()
    {

        bAnimator.SetBool("hasBlueberries", false);
        sAnimator.SetBool("hasSyrup", false);
        nAnimator.SetBool("hasPecans", false);
        cAnimator.SetBool("hasChocChips", false);
        wAnimator.SetBool("hasWhipCream", false);

    }

}
