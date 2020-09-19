using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject mainMenu;
	public GameObject levelSelection;

    public void StartGame(){
    	mainMenu.SetActive(false);
    	levelSelection.SetActive(true);
   	}

   	public void startLevel(){
   		SceneManager.LoadScene("Lvl_1");
   	}

   	public void startFreePlay(){
   		SceneManager.LoadScene("Free_Play");
   	}

    public void Exit(){
    	Application.Quit();
    }
}
