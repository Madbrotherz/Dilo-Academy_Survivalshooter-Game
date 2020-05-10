using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpeed : MonoBehaviour
{
    GameObject player;
    public GameObject particleSpeed;
    PlayerMovement playerMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Speed is Increased");
            playerMovementScript.speed = 10;
            particleSpeed.SetActive(true);
            Destroy(gameObject);
        }
    }
}
