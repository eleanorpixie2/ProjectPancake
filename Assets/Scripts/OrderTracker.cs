﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderTracker : MonoBehaviour {

    // Inspector fields for player counter ui texts.
    [Header("Successful Orders")]
    [SerializeField]
    private Text[] playerSuccessCounters;
    [Header("Failed Orders")]
    [SerializeField]
    private Text[] playerFailureCounters;

    // Counters.
    private int[] orderCompletions { get; set; }
    private int[] orderFailures { get; set; }

    // Testing.
    [Header("Testing")]
    [SerializeField]
    private bool test;

    public void CompletedOrder (int player)
    {
        // Update order completions.
        orderCompletions[player]++;
        playerSuccessCounters[player].text = "Completed: " + orderCompletions[player].ToString();
    }

    public void MissedOrder (int player)
    {
        // Update order failures.
        orderFailures[player]++;
        playerFailureCounters[player].text = "Missed: " + orderCompletions[player].ToString();
    }

    private void Start()
    {
        // Size array to match number of players in inspector.
        orderCompletions = new int[playerSuccessCounters.Length];
        orderFailures = new int[playerSuccessCounters.Length];
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
            MissedOrder(0);
            MissedOrder(1);
        }
    }
}
