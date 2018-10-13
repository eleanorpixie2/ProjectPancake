using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOrder : MonoBehaviour
{

    public Order thisOrder { get; private set; }

    [SerializeField]
    List<string> PancakeOrder;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void AssignOrder(Order newOrder)
    {

        thisOrder = newOrder;
        thisOrder.AssignGameObject(this.gameObject);

        PancakeOrder = new List<string>();
        for (int i = 0; i < thisOrder._requestedPancake.toppings.Count; i++)
        {


            PancakeOrder.Add(thisOrder._requestedPancake.toppings[i].ToString());

        }

    }

    public void RemoveOrder()
    {

        thisOrder = null;

    }

}
