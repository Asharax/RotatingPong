using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject enemy,ball;
    private float enemySpeed = 0.4f,initialPosX, ballPosY;
    private float maxDistance = 7f, proximity = 0.5f, enemyPosY;

    void Start()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy")[0];
        ball = GameObject.FindGameObjectsWithTag("Ball")[0];
        initialPosX = ball.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        ballPosY = ball.transform.position.y;
        enemyPosY = enemy.transform.position.y;
        if(ballPosY + proximity < enemyPosY | ballPosY - proximity > enemyPosY){
            Debug.Log("First if");
            if(ball.transform.position.x - initialPosX <= maxDistance){            
                Debug.Log("Catching the ball");
                Vector2 move = new Vector2(0,ball.transform.position.y - enemy.transform.position.y);
                enemy.transform.Translate(move * Time.deltaTime * enemySpeed);
            }
        }
    }
}
