using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoatHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int plasticBottlePoints = 0;
    public int plasticBagPoints = 0;
    public int glassBottlePoints = 0;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject pauseMenu;
    public GameObject gameUI;
    public AudioClip damage;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
            gameUI.SetActive(false);                
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(damage, transform.position);
            currentHealth = currentHealth - 10;
            healthBar.setHealth(currentHealth);
        }
        else if(col.tag == "PlasticBottle")
        {
            plasticBottlePoints += 1;
        }
        else if(col.tag == "PlasticBag")
        {
            plasticBagPoints += 1;
        }
        else if(col.tag == "GlassBottle")
        {
            glassBottlePoints += 1;
        }
    }
}
