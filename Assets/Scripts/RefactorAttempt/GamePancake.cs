using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePancake : MonoBehaviour
{

    [SerializeField]
    List<Sprite> pancakeSprites;

    [SerializeField]
    List<string> toppings;

    public Pancake thisPancake { get; private set; }

	// Use this for initialization
	void Start ()
    {

        thisPancake = new Pancake();

	}
	
	// Update is called once per frame
	void Update ()
    {

        toppings = new List<string>();

        for (int i = 0; i < thisPancake.toppings.Count; i++)
        {

            toppings.Add(thisPancake.toppings[i].ToString());

        }

	}

}
