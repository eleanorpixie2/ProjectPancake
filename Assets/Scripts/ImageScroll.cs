using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScroll : MonoBehaviour {


    [SerializeField]
    private Transform spriteTransform;

    [SerializeField]
    private float scrollDistanceX;

    [SerializeField]
    private float scrollDistanceY;

    [SerializeField]
    private float scrollRateX;

    [SerializeField]
    private float scrollRateY;


    private float startX;
    private float startY;

	// Use this for initialization
	void Start () {
        startX = spriteTransform.position.x;
        startY = spriteTransform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

        spriteTransform.position += new Vector3(scrollRateX * Time.deltaTime, scrollRateY * Time.deltaTime);

        if (spriteTransform.position.x > scrollDistanceX)
        {
            spriteTransform.position -= new Vector3(scrollDistanceX, 0);
        }
        if (spriteTransform.position.y > scrollDistanceY)
        {
            spriteTransform.position -= new Vector3(0, scrollDistanceX);
        }



	}
}
