using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingLegs : MonoBehaviour {

    GameObject legObject;
    Image leg;
    int legNum;

    public Sprite legOne, legoTwo;


	void Start () {
        legObject = this.gameObject;
        leg = legObject.GetComponent<Image>();
        legNum = 1;
	}

	void Update () {
        if (legNum == 1)
        {
            leg.sprite = legOne;
        }
        else if (legNum == 2)
        {
            leg.sprite = legoTwo;
        }
    }

    public void LegUp()
    {
        if (legNum < 2)
        {
            legNum++;
        }
        else if (legNum >= 2)
        {
            legNum = 1;
        }
    }

    public void LegDown()
    {
        if (legNum > 1)
        {
            legNum--;
        }
        else if (legNum <= 1)
        {
            legNum = 2;
        }
    }

    public int GetLegNum()
    {
        return legNum;
    }


}
