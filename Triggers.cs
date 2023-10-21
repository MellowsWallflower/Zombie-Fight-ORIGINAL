using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
   
    public float playerSpeed;
    public void Start()
    {
        playerSpeed = gameObject.GetComponent<Player>().speed;
        
    }

    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SpeedUp")
        {
            gameObject.GetComponent<Player>().speed *= 3;
        }
        else if (collision.gameObject.tag == "SlowDown")
        {
            gameObject.GetComponent<Player>().speed /= -3;
        }
        else if (collision.CompareTag("Obstacle"))
        {
            gameObject.GetComponent<Player>().lives -= 1;
           
        }
     
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<Player>().speed = playerSpeed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SpeedUp")
        {
            gameObject.GetComponent<Player>().speed *= 3;
        }
        else if (collision.gameObject.tag == "SlowDown")
        {
            gameObject.GetComponent<Player>().speed /= -3;
        }
        
    }

    //collectible

}
