using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoatHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int points = 0;
    public int currentHealth;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    // Update is called once per frame
    void Update()
    {
        if(currentHealth == 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0.0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            Debug.Log("hit enemy");
            currentHealth = currentHealth - 10;
            healthBar.setHealth(currentHealth);
        }
        else if(col.tag == "Coins")
        {
            points += 1;
            Debug.Log(points);
        }
    }
}
