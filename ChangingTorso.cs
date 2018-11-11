using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingTorso : MonoBehaviour {

    GameObject torsoObject;
    public Sprite torsoOne, torsoTwo;
    Image torso;
    int torsoNum;

	// Use this for initialization
	void Start () {
        torsoNum = 1;
        torsoObject = this.gameObject;
        torso = torsoObject.GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
        if (torsoNum == 1)
        {
            torso.sprite = torsoOne;
        }
        else if (torsoNum == 2)
        {
            torso.sprite = torsoTwo;
        }
    }

    public void TorsoUp()
    {
        if (torsoNum < 2)
        {
            torsoNum++;
        }
        else if (torsoNum >= 2)
        {
            torsoNum = 1;
        }
    }

    public void TorsoDown()
    {
        if (torsoNum > 1)
        {
            torsoNum--;
        }
        else if (torsoNum <= 1)
        {
            torsoNum = 2;
        }
    }

    public int GetTorsoNum()
    {
        return torsoNum;
    }

}
