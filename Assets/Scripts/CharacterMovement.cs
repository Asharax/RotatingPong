using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private GameObject player;
    private float playerSpeed, rotationSpeed;
    private Vector2 playerVelocity, move;
    private Vector3 vectorZ;
    void Start(){
        player =  this.gameObject;
        playerSpeed = 4f;
        rotationSpeed = 10000;
        vectorZ = new Vector3(0f, 0f, 1f);
    }
    void Update()
    {
        moveCharacter();
        if(Input.GetKeyDown(KeyCode.Space))
            RotatePaddle();
    }
    private void RotatePaddle(){
        player.transform.Rotate(vectorZ * Time.deltaTime * rotationSpeed);
    }
    private void moveCharacter(){
        move = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        object test = move * Time.deltaTime * playerSpeed;
        player.transform.Translate(move * Time.deltaTime * playerSpeed,Space.World);
    }
}
