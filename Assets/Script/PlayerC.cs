using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{   
    
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 18f;

    [SerializeField] float slowSpeed = 12f;
    [SerializeField] float boostSpeed = 30f; 

    void Update()
    {
       
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

      
        transform.Translate(steerAmount, 0,  0);

       
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "SpeedUp")
        {
            moveSpeed = boostSpeed;
        }
    }

    
}
