using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    GameObject pauseMenuObject;
    GameObject characterSelectionMenuObject;
    GameObject controlsMenuObject;
    [SerializeField]
    bool paused;
    bool openCharacterMenu;
    bool openControlsMenu;

	void Start () {

        pauseMenuObject = GameObject.Find("PauseMenu");
        characterSelectionMenuObject = GameObject.Find("CharacterSelectionMenu");

        paused = false;

        characterSelectionMenuObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
        pauseGame();
        openPauseMenu();
        CharacterMenu();
        ControlsMenu();
    }

    void openPauseMenu()
    {
        if(paused == true)
        {
            pauseMenuObject.SetActive(true);
        }else if(paused == false)
        {
            pauseMenuObject.SetActive(false);
        }
    }

    void pauseGame()
    {
        if (openCharacterMenu != true && openControlsMenu != true) {
            if (Input.GetButtonDown("Pause"))
            {
                paused = !paused;
            }
        }
    }

    void CharacterMenu()
    {
        if(openCharacterMenu == true)
        {
            characterSelectionMenuObject.SetActive(true);
        }else if (openCharacterMenu == false)
        {
            characterSelectionMenuObject.SetActive(false);
        }
    }

    void ControlsMenu()
    {
        if(openControlsMenu == true)
        {
            
        }else if(openControlsMenu == false)
        {

        }
    }

    //Resumes the game
    public void ResumeGame()
    {
        paused = false;
        openCharacterMenu = false;
        openControlsMenu = false;
    }

    #region Controls Menu

    //Opens up the Controls Menu
    public void OpenControlsMenu()
    {
        paused = false;
        openControlsMenu = true;
    }

    //Closes the Control Menu
    public void CloseControlsMenu()
    {
        paused = true;
        openControlsMenu = false;
    }

    #endregion

    #region Character Menu

    //Opens up the Character Menu
    public void OpenCharacterMenu()
    {
        paused = false;
        openCharacterMenu = true;
    }

    //Closes the Character Menu
    public void CloseCharacterMenu()
    {
        paused = true;
        openCharacterMenu = false;
    }

    #endregion

    public void Exit()
    {

    }
}
