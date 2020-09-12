using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatHealth : MonoBehaviour
{
    public int maxHealth = 100;
    int pickUp = 0;
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
        }
    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(currentHealth);
        if (col.tag == "Enemy")
        {
            Debug.Log("hit enemy");
            currentHealth = currentHealth - 10;
            healthBar.setHealth(currentHealth);
        }
        else if(col.tag == "Coins")
        {
            pickUp += 1;
        }
    }
}
