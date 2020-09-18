using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	Vector3 cachedScale;
    public void StartGame(){
    	SceneManager.LoadScene("Free_Play");
    }

    public void Exit(){
    	Application.Quit();
    }
}
