using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    //type of toppings
    public enum toppings { PECANS, WHIPCREAM, BLUBERRIES, CHOC_CHIPS, SYRUP };
    //list of orders
    public static List<List<toppings>> pancakeOrders;
    //random object
    private System.Random rnd;
    //Timer object
    List<Timer> timer;
    //amount of seconds allowed per order
    [SerializeField]
    int orderTime = 30;

    OrderTracker tracker = new OrderTracker();

    [SerializeField]
    int playerNum;

    // Use this for initialization
    void Start()
    {
        //initialize randome
        rnd = new System.Random();
        //max amount for list is 5
        pancakeOrders = new List<List<toppings>>();
        //intialize timer
        timer = new List<Timer>();
        //add order to list
        AddOrder();
        //start timer
        RunTimer(timer[0]);
    }

    // Update is called once per frame
    void Update()
    {
        //add orders as needed
        AddOrder();
        //add timers
        AddTimer();
        //check timers
        CheckTimer();
        //check for messed up or correct completed orders
        if (PlayerOrders.isMessedUp)
        {
            RemoveOrder(PlayerOrders.orderIndex);
            tracker.CompletedOrder(playerNum);
        }
        if (PlayerOrders.isCompleted)
        {
            RemoveOrder(PlayerOrders.orderIndex);
            tracker.MissedOrder(playerNum);
        }
    }

    void CheckTimer()
    {
        int i = 0;
        foreach (Timer t in timer)
        {
            if (t.secondsRemaining <= 0)
            {
                //remove order from list
                RemoveOrder(i);
            }
            i++;
        }
    }

    //starts timer for orders
    void RunTimer(Timer t)
    {
        t.StartTimer(orderTime);
    }


    void AddTimer()
    {
        if(timer.Count<5)
        {
            Timer t = new Timer();
            timer.Add(t);
            RunTimer(t);
        }
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
    void RemoveOrder(int i)
    {
        //remove order
        for (int n = i; n < pancakeOrders.Count-1; i++)
        {
            pancakeOrders[n] = pancakeOrders[n+1];
        }
        pancakeOrders.Remove(pancakeOrders[pancakeOrders.Count - 1]);
        //remove timer
        for(int n=i; n<timer.Count-1;i++)
        {
            timer[n] = timer[n + 1];
        }
        timer.Remove(timer[timer.Count - 1]);
    }



    //create random number
    int Random(int low, int high)
    {
        return rnd.Next(low, high);
    }
}
