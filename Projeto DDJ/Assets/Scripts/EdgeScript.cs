using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeScript : MonoBehaviour
{
    void Start(){
    
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other) {
     Debug.Log(other.collider.name);
         if (other.collider.name == "Player") {
             other.collider.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.collider.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
         }
     }


}
