using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D ballRb;
    private float ballSpeed = 0.5f,dist;
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.AddForce(transform.right * -1 * ballSpeed );
    }

    private void OnCollisionEnter2D(Collision2D other) {
        // Check if the collider is one of the paddles, player | enemy
        if(other!=null){
            BounceBall(other);
        }
    }
    private void BounceBall(Collision2D other){
            dist = other.transform.position.x - transform.position.x;
            // divided by absolute to send the ball to correct position.
            ballRb.AddForce(transform.right * -1 * dist/(Mathf.Abs(dist)) * ballSpeed );
    }
}
