using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public BoatHealth BoatHealth;
    public TMPro.TextMeshProUGUI scoreText;

    void Start()
    {
    	scoreText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = BoatHealth.points.ToString();
    }
}
