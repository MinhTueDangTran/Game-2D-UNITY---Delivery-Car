using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   
    [SerializeField] Color hasPackageColor = new Color(1,1,1,1);
    [SerializeField] Color noPackageColor = new Color(1,1,1,1);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackages;
    SpriteRenderer spriteRenderer;
    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch! OnCollision");
    }
     void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackages)
        {
            Debug.Log("Package picked up !!!");
            hasPackages = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,destroyDelay);
        }

        if(other.tag == "Customer" && hasPackages){
            Debug.Log("Customer picked up !!!");
            hasPackages = false;
            spriteRenderer.color = noPackageColor;
        }
        
    }


}
