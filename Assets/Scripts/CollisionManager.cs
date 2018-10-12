using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour {
    [SerializeField]
    int playerNum;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Blueberries")
        {
            if(Input.GetAxis("Topping"+playerNum)!=0)
            {
                PlayerOrders.eachOrderHas[0] = true;
            }
        }
        if (collision.gameObject.tag == "Syrup")
        {
            if (Input.GetAxis("Topping" + playerNum) != 0)
            {
                PlayerOrders.eachOrderHas[1] = true;
            }
        }
        if (collision.gameObject.tag == "Nuts")
        {
            if (Input.GetAxis("Topping" + playerNum) != 0)
            {
                PlayerOrders.eachOrderHas[2] = true;
            }
        }
        if (collision.gameObject.tag == "ChocoChips")
        {
            if (Input.GetAxis("Topping" + playerNum) != 0)
            {
                PlayerOrders.eachOrderHas[3] = true;
            }
        }
        if (collision.gameObject.tag == "Whipcream")
        {
            if (Input.GetAxis("Topping" + playerNum) != 0)
            {
                PlayerOrders.eachOrderHas[4] = true;
            }
        }
        if (collision.gameObject.tag == "Order1")
        {
            if (Input.GetAxis("Interact" + playerNum) != 0)
            {
                PlayerOrders.checkOrder(0);
                PlayerOrders.eachOrderHas = new List<bool>(7);
            }
        }
        if (collision.gameObject.tag == "Order2")
        {
            if (Input.GetAxis("Interact" + playerNum) != 0)
            {
                PlayerOrders.checkOrder(1);
                PlayerOrders.eachOrderHas = new List<bool>(7);
            }
        }
        if (collision.gameObject.tag == "Order3")
        {
            if (Input.GetAxis("Interact" + playerNum) != 0)
            {
                PlayerOrders.checkOrder(2);
                PlayerOrders.eachOrderHas = new List<bool>(7);
            }
        }
        if (collision.gameObject.tag == "Order4")
        {
            if (Input.GetAxis("Interact" + playerNum) != 0)
            {
                PlayerOrders.checkOrder(3);
                PlayerOrders.eachOrderHas = new List<bool>(7);
            }
        }
        if (collision.gameObject.tag == "Order5")
        {
            if (Input.GetAxis("Interact" + playerNum) != 0)
            {
                PlayerOrders.checkOrder(4);
                PlayerOrders.eachOrderHas = new List<bool>(7);
            }
        }
    }
}
