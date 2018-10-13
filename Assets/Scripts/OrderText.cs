using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderText : MonoBehaviour {
    [SerializeField]
    Text Order1;
    [SerializeField]
    Text Order2;
    [SerializeField]
    Text Order3;
    [SerializeField]
    Text Order4;
    [SerializeField]
    Text Order5;
	// Use this for initialization
	void Start () {
        //Order1 = GetComponent<Text>();
        //Order2 = GetComponent<Text>();
        //Order3 = GetComponent<Text>();
        //Order4 = GetComponent<Text>();
        //Order5 = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        Order1.text = "";
        for (int i = 0; i < OrderManager.pancakeOrders[0].Count; i++)
        {

            Order1.text += OrderManager.pancakeOrders[0][i].ToString()+"\n";
        }
        Order2.text = "";
        for (int i = 0; i < OrderManager.pancakeOrders[1].Count; i++)
        {

            Order2.text += OrderManager.pancakeOrders[1][i].ToString() + "\n";
        }
        Order3.text = "";
        for (int i = 0; i < OrderManager.pancakeOrders[2].Count; i++)
        {

            Order3.text += OrderManager.pancakeOrders[2][i].ToString() + "\n";
        }
        Order4.text = "";
        for (int i = 0; i < OrderManager.pancakeOrders[3].Count; i++)
        {

            Order4.text += OrderManager.pancakeOrders[3][i].ToString() + "\n";
        }
        Order5.text = "";
        for (int i = 0; i < OrderManager.pancakeOrders[4].Count; i++)
        {

            Order5.text += OrderManager.pancakeOrders[4][i].ToString() + "\n";
        }



    }
}
