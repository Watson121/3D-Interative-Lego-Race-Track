using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegoManMovement : MonoBehaviour {

    #region Declerations

    Transform player;   //Lego character Game Object
    GameObject cameraObject;

    Rigidbody playerRigidbody;
    CapsuleCollider playerCollider;

    [SerializeField]
    float speed; //Global speed, changes to different 
    float walkingSpeed;
    float sprintSpeed;

    bool walking;   //Checks if the player is walking
    [SerializeField]
    bool sprinting; //Checks if the player is running

    float verticalInput;
    float horizontalInput;

    float mouseSensitivity;
    float verticalRotation;
    float upDownRange;

	Animator playerAnimator;

    #endregion


    // Use this for initialization
    void Start () {

        player = GameObject.Find("Player").transform;
        cameraObject = GameObject.Find("Main Camera");
        playerRigidbody = player.GetComponent<Rigidbody>();
        playerCollider = player.GetComponent<CapsuleCollider>();
		playerAnimator = player.GetComponent<Animator>();
        walkingSpeed = 2.0f;
        sprintSpeed = 5.0f;

        mouseSensitivity = 5;
        verticalRotation = 0;
        upDownRange = 60;

    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale != 0)
        {
            if (cameraObject.activeSelf == true)
            {
                GetInput();
                PlayerCamera();
                settingSpeed();

                Time.timeScale = 1;
                Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed * 0.0167f;
                movement = Camera.main.transform.TransformDirection(movement);
                movement *= 60;

                Vector3 velocity = playerRigidbody.velocity;
                Vector3 velocityChange = (movement - velocity);
                velocityChange.x = Mathf.Clamp(velocityChange.x, -10, 10);
                velocityChange.z = Mathf.Clamp(velocityChange.z, -10, 10);
                velocityChange.y = 0;
                playerRigidbody.AddForce(velocityChange, ForceMode.VelocityChange);

                if (speed == walkingSpeed)
                {
                    playerAnimator.SetBool("Walk", true);
                }
            }
        }
    }

    void GetInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }

    void settingSpeed()
    {
        sprinting = Input.GetButton("Sprint");

        if(verticalInput < 0.01 || verticalInput > 0.01 || horizontalInput < 0.01 || horizontalInput > 0.001)
        {
            if(sprinting == true)
            {
                speed = sprintSpeed;
            }
            else if(sprinting == false)
            {

                speed = walkingSpeed;
            }
        }
        else
        {
            speed = 0f;
        }
    }

    void PlayerCamera()
    {
        if (cameraObject.activeSelf == true)
        {
            float RotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
            transform.Rotate(0, RotLeftRight, 0);

            verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
            Camera.main.transform.localRotation = Quaternion.Euler(15, -90, 0);
        }
    }

    


}
