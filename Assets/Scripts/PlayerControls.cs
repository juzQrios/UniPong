using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode quitKey = KeyCode.Escape;
    public float speed = 10.0f;
    public float boundY = 4.0f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Manage Paddle movement*/
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            vel.y = -speed;
        }
        else if (Input.GetKey(quitKey))
        {
            Application.Quit();
        }
        else
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        /*Out-of-bound conditions*/
        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if(pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
}
