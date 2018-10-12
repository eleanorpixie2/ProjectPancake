using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class OrderManager : MonoBehaviour {
    //type of toppings
    private enum toppings{PECANS,WHIPCREAM,BLUBERRIES,CHOC_CHIPS,SYRUP};
    //list of orders
    private List<List<toppings>> pancakeOrders;
    //random object
    private System.Random rnd;
    //Timer object
    Timer timer;



	// Use this for initialization
	void Start () {
        //initialize randome
		rnd=new System.Random();
        //max amount for list is 5
        pancakeOrders = new List<List<toppings>>(5);
        timer = new Timer();
	}
	
	// Update is called once per frame
	void Update () {
        //add orders as needed
        AddOrder();
        timer.
	}

    //add an order to the list
    void AddOrder()
    {
        if (pancakeOrders.Count < 5)
        {
            //get a single order, random amount of toppings, and keep track of toppings already added
            int numToppings = Random(0, 5);
            List<toppings> singleOrder = new List<toppings>();
            List<int> previousToppings = new List<int>(numToppings);
            //add random toppings, but only 1 of each kind
            for (int i = 0; i < numToppings; i++)
            {
                int topping = Random(0, 5);
                while (true)
                {
                    if (!previousToppings.Contains(topping))
                    {
                        break;
                    }
                    else
                    {
                        topping = Random(0, 5);
                    }
                }

                singleOrder.Add(((toppings)topping));
                previousToppings.Add(topping);

            }
            //add order to orders list
            pancakeOrders.Add(singleOrder);
        }
    }

    //remove order from the list
    void RemoveOrder()
    {
        pancakeOrders.Remove(pancakeOrders[0]);
    }



    int Random(int low,int high)
    {
        return rnd.Next(low,high);
    }
}
