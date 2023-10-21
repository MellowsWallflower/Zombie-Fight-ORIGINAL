using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed = 0.0f;
    Rigidbody2D rb;
   

    public int lives = 6;
    public int score = 0;
    public GameManagerScript gameManager;

    private bool isDead;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {

        float xDir = 0.0f;
        float yDir = 0.0f;
        if (Input.GetKey(KeyCode.W))
        {
            yDir = 1.0f;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            yDir = -1.0f;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            xDir = -1.0f;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            xDir = 1.0f;
        }

        if (lives <= 0 && !isDead)
        {
            isDead = true;
            gameManager.gameOver();
        }

     

       
     
        rb.velocity = new Vector2(xDir, yDir) * speed;

        

        

       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            gameObject.GetComponent<Player>().score += 1;
            Debug.Log("your score is : " + score);

        }

    }


    

 
}
