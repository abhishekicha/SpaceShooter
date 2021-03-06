using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;




    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
       CalculateMovement();

    }

    void CalculateMovement(){

         float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        // transform.Translate(Vector3.right * horizontalInput* _speed *Time.deltaTime);

        // transform.Translate(Vector3.up * verticalInput* _speed *Time.deltaTime);

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction*_speed *Time.deltaTime);

        //if player position on the y axis is greater than 0
        //y position is 0
        //else if position is on the y is less than -3.8f
        //y position = -3.8f


        // if(transform.position.y >= 0){
            
        //     transform.position = new Vector3(transform.position.x, 0, 0);
        // }else if(transform.position.y <= -3.8f){

        //     transform.position = new Vector3(transform.position.x, -3.8f, 0);
        // }

        //below code is an alternative

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);
        
        //if player on the x > 11
        //x position is = -11
        //else if player on the x is less -11
        // x position = 11 
        if(transform.position.x > 11.3f){
            
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }else if(transform.position.x < -11.3f){

            transform.position = new Vector3(11.3f,transform.position.y, 0);
        }

    }
}
