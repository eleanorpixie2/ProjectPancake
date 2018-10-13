using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePancake : MonoBehaviour
{

    [SerializeField]
    List<string> toppings;

    public Pancake thisPancake { get; private set; }

   Animator thisAnimator;

	// Use this for initialization
	void Start ()
    {

        thisPancake = new Pancake();
        thisAnimator = this.gameObject.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update ()
    {

        toppings = new List<string>();

        for (int i = 0; i < thisPancake.toppings.Count; i++)
        {

            toppings.Add(thisPancake.toppings[i].ToString());
            AddTopping(thisPancake.toppings[i]);

        }

	}

    void AddTopping(PancakeToppings toppingToAdd)
    {

        switch(toppingToAdd)
        {

            case PancakeToppings.BLUBERRIES:
                {

                    if (!thisAnimator.GetBool("hasBlueberries"))
                    {

                        thisAnimator.SetBool("hasBlueberries", true);

                    }
                    break;
                }
            case PancakeToppings.CHOC_CHIPS:
                {

                    if (!thisAnimator.GetBool("hasChocChips"))
                    {

                        thisAnimator.SetBool("hasChocChips", true);

                    }
                    break;
                }
            case PancakeToppings.PECANS:
                {

                    if (!thisAnimator.GetBool("hasPecans"))
                    {

                        thisAnimator.SetBool("hasPecans", true);

                    }
                    break;
                }
            case PancakeToppings.SYRUP:
                {

                    if (!thisAnimator.GetBool("hasSyrup"))
                    {

                        thisAnimator.SetBool("hasSyrup", true);

                    }
                    break;
                }
            case PancakeToppings.WHIPCREAM:
                {

                    if (!thisAnimator.GetBool("hasWhipCream"))
                    {

                        thisAnimator.SetBool("hasWhipCream", true);

                    }
                    break;
                }

        }

    }

}
