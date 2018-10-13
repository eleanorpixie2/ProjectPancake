using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RF_OrderManager : MonoBehaviour
{

#if DEBUG

    public List<string> ordersInInspector;
    public int currentOrderCounter;

#endif

    [SerializeField]
    int orderTime = 30;

    [SerializeField]
    float MaxOrders;

    [SerializeField]
    float timeForNextOrder = 10;

    [SerializeField]
    OrderTracker orderTracker;

    List<Order> pancakeOrders;

    public int orderCounter { get; private set; }

    Timer GlobalTimer;

    System.Random rnd;


    // Use this for initialization
    void Start ()
    {

        // initialize randome
        rnd = new System.Random();
        
        // max amount for list is 5
        pancakeOrders = new List<Order>();

        // Add first Order
        AddOrder();

    }
	
	// Update is called once per frame
	void Update ()
    {

        // Add order within set amount of time
        StartCoroutine(TimeBeforeNextOrder());

#if DEBUG

        ordersInInspector = new List<string>();
        for (int i = 0; i < pancakeOrders.Count; i++)
        {

            ordersInInspector.Add(pancakeOrders[i].orderNumber.ToString());

        }
        currentOrderCounter = orderCounter;

#endif
        // check timer count of individual orders
        CheckTimers();



	}

    void CheckTimers()
    {

        // keep track of order numbers that needs to be removed
        List<int> ordersToRemove = new List<int>();

        // check each order timer
        // then if timer has ended
        // add order number to ordersToRemove list
        if (pancakeOrders != null)
        {

            foreach (Order o in pancakeOrders)
            {

                if (o.pancakeTimer.secondsRemaining <= 0)
                {

                    ordersToRemove.Add(o.orderNumber);

                }

            }

        }

        // Make sure ordersToRemove is not empty
        // then remove orders via their order number
        // order will be removed no matter how list is ordered
        // as long as its order number is correct
        if (ordersToRemove.Count != 0)
        {

            for (int i = 0; i < ordersToRemove.Count; i++)
            {

                RemoveOrder(ordersToRemove[i]);

            }

        }

    }

    void AddOrder()
    {

        //get a single order, random amount of toppings, and keep track of toppings already added
        int numToppings = rnd.Next(1, 6);

        Pancake newPancakeOrder = new Pancake();
        List<int> previousToppings = new List<int>(numToppings);

        for (int i = 0; i < numToppings; i++)
        {

            int topping = rnd.Next(0, 5);
            while (true)
            {
                if (!previousToppings.Contains(topping))
                {

                    break;

                }
                else
                {

                    topping = rnd.Next(0, 5);

                }

            }
            newPancakeOrder.AddTopping((PancakeToppings)topping);
            previousToppings.Add(topping);

        }

        // Increase Order Number
        orderCounter++;

        // Add Order
        // Create order instance
        // Change order time as necessary
        Order newOrder = new Order(newPancakeOrder, orderCounter, orderTime);
        newOrder.StartOrder();

    }

    // Remove order via Order's order number
    void RemoveOrder(int removeOrderViaOrderNumber)
    {

        int orderIndexToRemove = -1;

        for (int i = 0; i < pancakeOrders.Count; i++)
        {

            if (pancakeOrders[i].orderNumber == removeOrderViaOrderNumber)
            {

                orderIndexToRemove = i;

            }

        }

        if (orderIndexToRemove != -1)
        {

            pancakeOrders[orderIndexToRemove].DeleteTimer();
            pancakeOrders.RemoveAt(orderIndexToRemove);

        }

    }

    // Coroutine before adding the next order within a set amount of time
    IEnumerator TimeBeforeNextOrder()
    {

        yield return new WaitForSeconds(timeForNextOrder);
        if (pancakeOrders.Count < MaxOrders)
        {

            AddOrder();

        }

    }

}
