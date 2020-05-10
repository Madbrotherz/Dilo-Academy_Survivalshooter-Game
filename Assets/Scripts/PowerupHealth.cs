using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupHealth : MonoBehaviour
{
    GameObject player;
    PlayerHealth playerHealthScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerHealthScript = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (playerHealthScript.currentHealth < 100)
            {
                Debug.Log("Health is Increased");
                playerHealthScript.currentHealth += 30;
                playerHealthScript.healthSlider.value = playerHealthScript.currentHealth;
                Destroy(gameObject);
            }
        }
    }
}
