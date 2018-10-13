using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderTracker : MonoBehaviour {

    // Inspector fields for player counter ui texts.
    [Header("Successful Orders")]
    [SerializeField]
    Text player1;
    [SerializeField]
    Text player2;
   

    // Counters.
    public static int CompleterdOrders1 = 0;
    public static int CompleterdOrders2 = 0;
    private int[] orderFailures { get; set; }

    // Testing.
    [Header("Testing")]
    [SerializeField]
    private bool test;

    public void CompletedOrder(int player)
    {
        // Update order completions.
        switch (player)
        {
            case 1:
                CompleterdOrders1++;
                player1.text = "Completed: " + CompleterdOrders1.ToString();
                break;
            case 2:
                CompleterdOrders2++;
                player2.text = "Completed: " + CompleterdOrders2.ToString();
                break;
        }


    }


    private void Start()
    {

    }

    //Testing only.
    float lastHit = 0;
    private void Update()
    {
        if (test && Time.time - 1 > lastHit)
        {
            lastHit = Time.time;

            // Increment all counters.
            CompletedOrder(0);
            CompletedOrder(1);
           
        }
    }
}
