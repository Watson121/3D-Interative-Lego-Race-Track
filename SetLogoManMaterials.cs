using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLogoManMaterials : MonoBehaviour {

    #region DECLERATIONS

    #region Head
    [Header("Head Materials")]
    public Material head1;
    public Material head2;
    public Material head3;

    GameObject headObject;
    [SerializeField]
    MeshRenderer headMesh;
    int headNum;
    #endregion

    #region Torso
    [Header("Torso Materials")]
    public Material torso1;
    public Material torso2;

    GameObject torsoObject, armOneObejct, armTwoObject;
    MeshRenderer torsoMesh, armOneMesh, armTwoMesh;
    Material torsoBase;
    int torsoNum;
    #endregion

    #region Leg
    [Header("Leg Materials")]
    public Material leg1;
    public Material leg2;

    GameObject legOneObject, legTwoObject;
    MeshRenderer legOneMesh, legTwoMesh;
    Material legBase;
    int legNum;
    #endregion

    #endregion

    // Use this for initialization
    void Start () {

        //Head
        headObject = GameObject.Find("PlayerHead");
        headMesh = headObject.GetComponent<MeshRenderer>();

        //Torso
        torsoObject = GameObject.Find("PlayerBody");
        armOneObejct = GameObject.Find("UpperArmPlayer");
        armTwoObject = GameObject.Find("UpperArmTwoPlayer");
        torsoMesh = torsoObject.GetComponent<MeshRenderer>();
        armOneMesh = armOneObejct.GetComponent<MeshRenderer>();
        armTwoMesh = armTwoObject.GetComponent<MeshRenderer>();

        legOneObject = GameObject.Find("LegOnePlayer");
        legTwoObject = GameObject.Find("LegTwoPlayer");
        legOneMesh = legOneObject.GetComponent<MeshRenderer>();
        legTwoMesh = legTwoObject.GetComponent<MeshRenderer>();

        headNum = 1;
        torsoNum = 1;
        legNum = 1;

        SettingTheTextures();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SettingTheTextures()
    {
        switch (headNum)
        {
            case 1:
                headMesh.material = head1;
                break;
            case 2:
                headMesh.material = head2;
                break;
            case 3:
                headMesh.material = head3;
                break;
            default:
                break;
        }

        switch (torsoNum)
        {
            case 1:
                torsoMesh.material = torso1;
                armOneMesh.material = torso1;
                armTwoMesh.material = torso1;
                break;
            case 2:
                torsoMesh.material = torso2;
                armOneMesh.material = torso2;
                armTwoMesh.material = torso2;
                break;
            default:
                break;
        }

        switch (legNum)
        {
            case 1:
                legOneMesh.material = leg1;
                legTwoMesh.material = leg1;
                torsoMesh.materials[1] = leg1;
                break;
            case 2:
                legOneMesh.material = leg2;
                legTwoMesh.material = leg2;
                torsoMesh.materials[1] = leg2;
                break;
            default:
                break;
        }
    }


    #region Setting The Materials Numbers 

    public void SetNums(int h, int t, int l)
    {
        headNum = h;
        torsoNum = t;
        legNum = l;

        SettingTheTextures();
        print(headNum);
    }

    #endregion
}
