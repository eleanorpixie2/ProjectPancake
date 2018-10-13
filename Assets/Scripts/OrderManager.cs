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

    Dictionary<int, List<toppings>> Orders;

    // Use this for initialization
    void Start()
    {
        //initialize randome
        rnd = new System.Random();
        //max amount for list is 5
        pancakeOrders = new List<List<toppings>>();
        //intialize timer
        timer = new List<Timer>();
        //add orders as needed
        AddOrder();
        //add timers
        AddTimer();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Between());
        //add orders as needed
        AddOrder();
        //add timers
        AddTimer();
        
        //check timers
        CheckTimer();
        //check for messed up or correct completed orders
        if (PlayerOrders.isMessedUp)
        {
            //RemoveOrder(PlayerOrders.orderIndex);
            tracker.CompletedOrder(playerNum);
        }
        if (PlayerOrders.isCompleted)
        {
            //singleOrderRemoveOrder(PlayerOrders.orderIndex);
            tracker.MissedOrder(playerNum);
        }
    }

    void CheckTimer()
    {
        Debug.Log(timer[0].secondsRemaining);
        if (timer[0].secondsRemaining <= 0)
        {

            //remove order from list
            RemoveOrder(Orders[0]);
            AddOrder();
        }
        //if (timer[1].secondsRemaining <= 1)
        //{
        //    //remove order from list
        //    RemoveOrder(1);
        //}
        //if (timer[2].secondsRemaining <= 1)
        //{
        //    //remove order from list
        //    RemoveOrder(2);
        //}
        //if (timer[3].secondsRemaining <= 1)
        //{
        //    //remove order from list
        //    RemoveOrder(3);
        //}
        //if (timer[4].secondsRemaining <= 1)
        //{
        //    //remove order from list
        //    RemoveOrder(4);
        //}
    }

    //starts timer for orders
    void RunTimer(Timer t)
    {
        t.StartTimer(orderTime);
    }


    void AddTimer()
    {
        //if(timer.Count<5)
        //{
        //    Timer t = new Timer();
        //    timer.Add(t);
        //    RunTimer(t);
        //    Debug.Log(timer.Count);
        //}

        if (timer.Count < 5)
        {

            timer.Add(GameObject.Find("Timer").GetComponent<Timer>());
            RunTimer(timer[0]);

        }

    }

    //add an order to the list
    void AddOrder()
    {
        if (pancakeOrders.Count < 5)
        {
            //get a single order, random amount of toppings, and keep track of toppings already added
            int numToppings = Random(1, 6);
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
            Orders.Add(pancakeOrders.Count, singleOrder);
        }
    }

    //remove order from the list
    void RemoveOrder(List<toppings> ToRemove)
    {
        pancakeOrders.Remove(ToRemove);
        //remove order
        //for (int n = i; n < pancakeOrders.Count-1; i++)
        //{
        //    pancakeOrders[n] = pancakeOrders[n+1];
        //}
        //pancakeOrders.Remove(pancakeOrders[pancakeOrders.Count - 1]);
        ////remove timer
        //for(int n=i; n<timer.Count-1;i++)
        //{
        //    timer[n] = timer[n + 1];
        //}
        //timer.Remove(timer[timer.Count - 1]);
    }

IEnumerator Between()
    {
        yield return new WaitForSeconds(10);
    }

    //create random number
    int Random(int low, int high)
    {
        return rnd.Next(low, high);
    }
}
