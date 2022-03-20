using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private GameObject player;
    private float playerSpeed = 4f;
    private Vector2 playerVelocity;


    // Start is called before the first frame update
    void Start(){
        Debug.Log("The game is started"); 
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    void Update()
    {
        Vector2 move = new Vector2(0,Input.GetAxis("Vertical"));
        object test = move * Time.deltaTime * playerSpeed;
        Debug.Log("test");
        player.transform.Translate(move * Time.deltaTime * playerSpeed);
        // player.transform.Translate(playerVelocity * Time.deltaTime);
    }
}
