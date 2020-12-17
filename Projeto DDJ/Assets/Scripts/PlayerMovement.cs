using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


public float speed = 5f;
private Rigidbody2D r;
 
 
    // Start is called before the first frame update
    void Start()
    {
        r = gameObject.GetComponent<Rigidbody2D>();
    }

      void FixedUpdate()
    {
        float moveX = 0f;
        float moveY = 0f;
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            moveY = +1f;
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            moveY = -1f;
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            moveX = -1f;
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
         moveX = +1f;

         Vector3 moveDir = new Vector3(moveX,moveY).normalized;
         transform.position += moveDir *speed * Time.deltaTime;
     
    }

}
