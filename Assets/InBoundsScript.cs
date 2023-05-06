using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBoundsScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            if (name == "InBoundsLeft")
            {
                logic.addPlayer1Score();
            }
            else if (name == "InBoundsRight")
            {
                logic.addPlayer2Score();
            }
        }
    }
}
