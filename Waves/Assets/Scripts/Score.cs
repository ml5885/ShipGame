using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public BoatHealth BoatHealth;
    public TMPro.TextMeshProUGUI plasticBottleText;
    public TMPro.TextMeshProUGUI plasticBagText;
    public TMPro.TextMeshProUGUI glassBottleText;

    void Start()
    {
    	plasticBottleText.GetComponent<TMPro.TextMeshProUGUI>();
        plasticBagText.GetComponent<TMPro.TextMeshProUGUI>();
        glassBottleText.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        plasticBottleText.text = "Plastic Bottle x " + BoatHealth.plasticBottlePoints.ToString();
        plasticBagText.text = "Plastic Bag x " + BoatHealth.plasticBagPoints.ToString();
        glassBottleText.text = "Glass Bottle x " + BoatHealth.glassBottlePoints.ToString();
    }
}
