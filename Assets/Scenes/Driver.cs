using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   
    [SerializeField]float steerSpeed = 0.1f;
    [SerializeField]float moveSpeed = 20f; 
    [SerializeField]float slowSpeed = 10f; 
     [SerializeField]float BootsSpeed = 40f; 
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime; 
        float moveAmount = Input.GetAxis("Vertical")* moveSpeed*Time.deltaTime;
     transform.Rotate(0,0,-steerAmount); 
     transform.Translate(0,moveAmount,0); 
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("you're Collision !!! Owllllll");
        moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Boots"){
            Debug.Log("You're Boosting !!!");
            moveSpeed = BootsSpeed;
    }
    }
}
