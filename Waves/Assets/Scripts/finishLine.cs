using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
	public GameObject pointMenu;
	public GameObject gameUI;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
        	gameUI.SetActive(false);
            Time.timeScale = 0f;
            pointMenu.SetActive(true);
        }
    }
}
