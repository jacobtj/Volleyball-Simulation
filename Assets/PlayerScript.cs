using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpHeight;
    public float moveSpeed;
    private Vector2 initialPos;
    private float distance;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (name == "Player")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) == true)
            {
                myRigidbody.velocity = Vector2.up * jumpHeight;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
            {
                myRigidbody.velocity = Vector2.left * moveSpeed;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) == true)
            {
                myRigidbody.velocity = Vector2.down * moveSpeed;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) == true)
            {
                myRigidbody.velocity = Vector2.right * moveSpeed;
            }
        }
        else if (name == "Player2")
        {
            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                myRigidbody.velocity = Vector2.up * jumpHeight;
            }
            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                myRigidbody.velocity = Vector2.left * moveSpeed;
            }
            if (Input.GetKeyDown(KeyCode.S) == true)
            {
                myRigidbody.velocity = Vector2.down * moveSpeed;
            }
            if (Input.GetKeyDown(KeyCode.D) == true)
            {
                myRigidbody.velocity = Vector2.right * moveSpeed;
            }
        }
        else if (name == "AIPlayer")
        {
            distance = Vector2.Distance(transform.position, ball.transform.position);
            Vector2 direction = ball.transform.position - transform.position;
            transform.position = Vector2.MoveTowards(this.transform.position, ball.transform.position, moveSpeed * Time.deltaTime);
        }
    }

    [ContextMenu("Reset Position")]
    public void resetPosition()
    {
        gameObject.transform.position = initialPos;
    }

    
}
