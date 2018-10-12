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
    private static List<List<bool>> eachOrderHas;

    //index of order
    public static int orderIndex;

	// Use this for initialization
	void Start () {
        
		for(int i=0;i<OrderManager.pancakeOrders.Count;i++)
        {
            List<bool> singleOrder = new List<bool>();
            singleOrder.Add(hasBluberries);
            singleOrder.Add(hasSyrup);
            singleOrder.Add(hasNuts);
            singleOrder.Add(hasChocChips);
            singleOrder.Add(hasWhipCream);
            singleOrder.Add(isCompleted);
            singleOrder.Add(isMessedUp);
            eachOrderHas.Add(singleOrder);
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
           if(eachOrderHas[i][n])
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
