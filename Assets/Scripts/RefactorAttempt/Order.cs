using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order
{



    // Expected time for pancake to be prepared
    float pancakePreparationTime = 15.0f;

    // Requested Pancake to be prepared
    Pancake requestedPancake;

    // Requested Pancake to be prepared
    public Pancake _requestedPancake { get { return requestedPancake; } }

    // Timer to keep track of pancake order expiration
    public Timer pancakeTimer { get; private set; }

    // Order number to keep track of the order
    public int orderNumber { get; private set; }

    //
    public GameObject bindedGameObject { get; private set; }

    // Constructor with a simple pancake request
    public Order(Pancake request, int _orderNumber)
    {

        // Keep a copy of Pancake Order
        requestedPancake = request;

        // Keep track of _orderNumber
        orderNumber = _orderNumber;

        // Setup timer for Order
        SetupTimer();

    }

    // Constructor with pancake request under a specified time frame
    public Order(Pancake request, int _orderNumber, float orderTimerCount)
    {

        // Keep a copy of Pancake Order
        requestedPancake = request;
        
        // Specified order time
        pancakePreparationTime = orderTimerCount;

        // Keep track of _orderNumber
        orderNumber = _orderNumber;

        // Setup timer for Order
        SetupTimer();

    }

    //
    public void SetupTimer()
    {

        // Create a new timer gameobject
        GameObject NewTimer = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/SpawnableGameTimer"));
        NewTimer.name = "Timer for Order: " + orderNumber.ToString();

        // Make sure the Parent Gameobject exists otherwise spawn one
        if (GameObject.Find("Timers") == null)
        {

            GameObject Timers = new GameObject("Timers");
            Timers.transform.position = Vector3.zero;

        }

        // Set new timer parent to Timers gameobject
        NewTimer.transform.parent = GameObject.Find("Timers").transform;

        // Assign new Timer to the order's pancakeTimer
        pancakeTimer = NewTimer.GetComponent<Timer>();

    }

    // Destroy Pancake Timer to prevent too many timers in scene
    public void DeleteTimer()
    {

        GameObject.Destroy(pancakeTimer.gameObject);

    }

    // Start order timer
    public void StartOrder()
    {

        if (pancakeTimer != null)
        {

            pancakeTimer.StartTimer(pancakePreparationTime);

        }

    }

    // Check if order was good
    public bool CheckOrder(Pancake orderSubmission)
    {

        // Make a copy of topping list from submission and requested pancakes
        List<PancakeToppings> submissionList = orderSubmission.toppings;
        List<PancakeToppings> requestedList = requestedPancake.toppings;

        // Assume the order is messed up
        bool Success = false;

        // Check submission against requested and set Success to false if match failed
        // One missed topping a fail
        for (int i = 0; i < requestedList.Count; i++)
        {

            if (!submissionList.Contains(requestedList[i]))
            {

                Success = false;

            }
            else
            {

                Success = true;

            }

        }

        return Success;

    }

    public void AssignGameObject(GameObject thisGameObject)
    {

        bindedGameObject = thisGameObject;

    }

}
