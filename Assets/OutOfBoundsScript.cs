using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OutOfBoundsScript : MonoBehaviour
{
    public LogicScript logic;
    public BallScript ball;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            if (ball.p1LastTouch == true)
            {
                logic.addPlayer2Score();
            }
            else if (ball.p2LastTouch == true)
            {
                logic.addPlayer1Score();
            }
        }
    }
}
