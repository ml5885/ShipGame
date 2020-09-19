using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelMenu : MonoBehaviour
{
	public BoatHealth BoatHealth;
	public Timer timer;
	public TMPro.TextMeshProUGUI plasticBottleNumber;
	public TMPro.TextMeshProUGUI glassBottleNumber;
	public TMPro.TextMeshProUGUI plasticBagNumber;
	public TMPro.TextMeshProUGUI timeNumber;
	public TMPro.TextMeshProUGUI scoreText;
	public TMPro.TextMeshProUGUI plasticBottleScore;
	public TMPro.TextMeshProUGUI glassBottleScore;
	public TMPro.TextMeshProUGUI plasticBagScore;
	public TMPro.TextMeshProUGUI timeScore;
	public TMPro.TextMeshProUGUI time;

    void Start()
    {
        plasticBagScore = plasticBagScore.GetComponent<TMPro.TextMeshProUGUI>();
        plasticBottleScore = plasticBottleScore.GetComponent<TMPro.TextMeshProUGUI>();
        plasticBagNumber = plasticBagNumber.GetComponent<TMPro.TextMeshProUGUI>();
        plasticBottleNumber = plasticBottleNumber.GetComponent<TMPro.TextMeshProUGUI>();
        timeNumber = timeNumber.GetComponent<TMPro.TextMeshProUGUI>();
        timeScore = timeScore.GetComponent<TMPro.TextMeshProUGUI>();
        scoreText = scoreText.GetComponent<TMPro.TextMeshProUGUI>();
        glassBottleScore = glassBottleScore.GetComponent<TMPro.TextMeshProUGUI>();
        glassBottleNumber = glassBottleNumber.GetComponent<TMPro.TextMeshProUGUI>();
        time = time.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        plasticBottleNumber.text = "Plastic Bottle x " + BoatHealth.plasticBottlePoints.ToString();
        glassBottleNumber.text = "Glass Bottle x " + BoatHealth.glassBottlePoints.ToString();
        plasticBagNumber.text = "Plastic Bag x " + BoatHealth.plasticBagPoints.ToString();
        timeNumber.text = "Time: " + time.text;
        scoreText.text = string.Format("{0:3}",((BoatHealth.plasticBottlePoints*10) + (BoatHealth.glassBottlePoints*5) + (BoatHealth.plasticBagPoints*2) + (timer.timeRemaining*0.5)));
        plasticBottleScore.text = "+" + (BoatHealth.plasticBottlePoints*10);
        glassBottleScore.text = "+" + (BoatHealth.glassBottlePoints*5);
        plasticBagScore.text = "+" + (BoatHealth.plasticBagPoints*2);
        timeScore.text = "+" + Mathf.Round(timer.timeRemaining/2).ToString();
    }

    public void onRestart(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    	Time.timeScale = 1f; 
    }

    public void onMainMenu(){
    	SceneManager.LoadScene("Main Menu");
    	Time.timeScale = 1f; 
    }

    public void onNextLevel(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
