using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public bool p1LastTouch = false;
    public bool p2LastTouch = false;
    public Rigidbody2D myRigidbody;
    private Vector2 initialPos;
    //private Vector2 initialV;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            p1LastTouch = true;
            p2LastTouch = false;
        }
        else if (collision.gameObject.layer == 8)
        {
            p2LastTouch = true;
            p1LastTouch = false;
        }
    }

    [ContextMenu("Reset Position")]
    public void resetPosition()
    {
        gameObject.transform.position = initialPos;
        myRigidbody.velocity = Vector2.zero;
    }
}
