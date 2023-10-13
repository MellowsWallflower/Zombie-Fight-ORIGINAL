using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       float Speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.postion.y + Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.postion.y + Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x, transform.postion.y + Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x, transform.postion.y + Speed * Time.deltaTime);
        }
    }
}
