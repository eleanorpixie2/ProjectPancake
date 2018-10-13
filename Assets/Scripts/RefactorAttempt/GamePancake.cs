using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePancake : MonoBehaviour
{

    [SerializeField]
    List<Sprite> pancakeSprites;

    public Pancake thisPancake { get; private set; }

	// Use this for initialization
	void Start ()
    {

        thisPancake = new Pancake();

	}
	
	// Update is called once per frame
	void Update ()
    {

	}

}
