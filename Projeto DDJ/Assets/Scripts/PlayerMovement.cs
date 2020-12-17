using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


public float speed = 5f;
private Rigidbody2D r;
private Animator animator;
 
 
    // Start is called before the first frame update
    void Start()
    {
        r = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

      void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        animator.SetFloat("DireccaoX", moveX);
        animator.SetFloat("DireccaoY", moveY);

     /*
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            animator.SetFloat("DireccaoY",1);
        }if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            moveY = -1f;
            animator.SetFloat("DireccaoY",-1);
        }if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            moveX = -1f;
            animator.SetFloat("DireccaoX",-1);
        }if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            animator.SetFloat("DireccaoX",1);
             moveX = +1f;
        }
        
     */
         Vector3 moveDir = new Vector3(moveX, 0).normalized;
         transform.position += moveDir *speed * Time.deltaTime;
     
    }

}
