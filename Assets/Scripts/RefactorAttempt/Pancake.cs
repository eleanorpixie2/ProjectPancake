using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pancake
{

    // list of toppings for the pancake
    public List<PancakeToppings> toppings { get; private set; }

    public Pancake()
    {

        toppings = new List<PancakeToppings>();

    }

	// call function to add toppings to new pancake
    public void AddTopping(PancakeToppings newTopping)
    {

        toppings.Add(newTopping);

    }

}
