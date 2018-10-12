using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrders : MonoBehaviour {
    //bluberries were added
    private bool hasBluberries;

    //syrup was added
    private bool hasSyrup;

    //nuts were added
    private bool hasNuts;

    //chocolate chips were added
    private bool hasChocChips;

    //whip cream was added
    private bool hasWhipCream;

    //was complete correctly
    public static bool isCompleted;

    //was completed incorrectly
    public static bool isMessedUp;

    //what each character created order has
    public static List<bool> eachOrderHas;

    //index of order
    public static int orderIndex;

	// Use this for initialization
	void Start () {
        
		for(int i=0;i<OrderManager.pancakeOrders.Count;i++)
        {
            eachOrderHas = new List<bool>();
            eachOrderHas.Add(hasBluberries);
            eachOrderHas.Add(hasSyrup);
            eachOrderHas.Add(hasNuts);
            eachOrderHas.Add(hasChocChips);
            eachOrderHas.Add(hasWhipCream);
            eachOrderHas.Add(isCompleted);
            eachOrderHas.Add(isMessedUp);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //check what the order has against what it shoud have
    public static void checkOrder(int i)
    {
        orderIndex = i;
        for(int n=0; n<OrderManager.pancakeOrders[i].Count;n++)
        {
           if(eachOrderHas[i])
            {
                if(n==0)
                {
                    if (OrderManager.pancakeOrders[i].Contains(OrderManager.toppings.BLUBERRIES))
                    {
                        isCompleted = true;
                    }
                    else
                    {
                        isMessedUp = true;
                        break;
                    }
                }
                if (n == 1)
                {
                    if (OrderManager.pancakeOrders[i].Contains(OrderManager.toppings.SYRUP))
                    {
                        isCompleted = true;
                    }
                    else
                    {
                        isMessedUp = true;
                        break;
                    }
                }
                if (n == 2)
                {
                    if (OrderManager.pancakeOrders[i].Contains(OrderManager.toppings.PECANS))
                    {
                        isCompleted = true;
                    }
                    else
                    {
                        isMessedUp = true;
                        break;
                    }
                }
                if (n == 3)
                {
                    if (OrderManager.pancakeOrders[i].Contains(OrderManager.toppings.CHOC_CHIPS))
                    {
                        isCompleted = true;
                    }
                    else
                    {
                        isMessedUp = true;
                        break;
                    }
                }
                if (n == 4
                    )
                {
                    if (OrderManager.pancakeOrders[i].Contains(OrderManager.toppings.WHIPCREAM))
                    {
                        isCompleted = true;
                    }
                    else
                    {
                        isMessedUp = true;
                        break;
                    }
                }

            }
        }
    }
}
