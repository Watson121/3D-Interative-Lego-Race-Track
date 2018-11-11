using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionMenu : MonoBehaviour {
    
    #region Declerations

    //Objects in the Game World
    GameObject player;
    SetLogoManMaterials setLogoManMaterials;


    //Objects on the UI
    Transform headUI, torsoUI, legUI;
    ChangingHead head;
    ChangingTorso torso;
    ChangingLegs legs;

    [SerializeField]
    int faceNum, torsoNum, legNum;

    #endregion

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        setLogoManMaterials = player.GetComponent<SetLogoManMaterials>();

        headUI = GameObject.Find("FaceUI").transform;
        torsoUI = GameObject.Find("TorsoUI").transform;
        legUI = GameObject.Find("LegsUI").transform;

        head = headUI.GetComponent<ChangingHead>();
        torso = torsoUI.GetComponent<ChangingTorso>();
        legs = legUI.GetComponent<ChangingLegs>();



    }
	
	// Update is called once per frame
	void Update () {
        getNums();
    }

    void getNums()
    {
        faceNum = head.getHeadNum();
        torsoNum = torso.GetTorsoNum();
        legNum = legs.GetLegNum();
    }


    public void Confrim()
    {
        setLogoManMaterials.SetNums(faceNum, torsoNum, legNum);
    }




}
