using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingHead : MonoBehaviour {

    GameObject headObject;
    Image face;
    public Sprite headOne, headTwo, headThree;
    [SerializeField]
    int headNum;

	// Use this for initialization
	void Start () {
        headNum = 1;
        headObject = this.gameObject;
        face = headObject.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (headNum == 1)
        {
            face.sprite = headOne;
        }else if(headNum == 2)
        {
            face.sprite = headTwo;
        }else if(headNum == 3)
        {
            face.sprite = headThree;
        }
	}

    public void changeHeadUp()
    {
        if (headNum < 3)
        {
            headNum++;
        }else if(headNum >= 3)
        {
            headNum = 1;
        }
    }

    public void changeHeadDown()
    {
        if (headNum > 1)
        {
            headNum--;
        }else if(headNum <= 1)
        {
            headNum = 3;
        }
    }

    public int getHeadNum()
    {
        return headNum;
    }


}
