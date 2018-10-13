using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOrder : MonoBehaviour
{

    public Text thisText;

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

        this.thisText.text = string.Empty;
        if (thisOrder != null)
        {

            for (int i = 0; i < thisOrder._requestedPancake.toppings.Count; i++)
            {

                this.thisText.text += thisOrder._requestedPancake.toppings[i].ToString() + "\n";

            }

        }

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
