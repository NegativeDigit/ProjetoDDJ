/*
 * Copyright (c) 2017 Razeware LLC
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * Notwithstanding the foregoing, you may not use, copy, modify, merge, publish, 
 * distribute, sublicense, create a derivative work, and/or sell copies of the 
 * Software in any work that is designed, intended, or marketed for pedagogical or 
 * instructional purposes related to programming, coding, application development, 
 * or information technology.  Permission for such use, copying, modification,
 * merger, publication, distribution, sublicensing, creation of derivative works, 
 * or sale is expressly withheld.
 *    
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float swingForce = 4f;
    public float speed = 1f;
    public float jumpSpeed = 3f;
    public Vector2 ropeHook;
    public bool isSwinging;
    public bool groundCheck;
    private GameManager gameManager;
    private SpriteRenderer playerSprite;
    private Rigidbody2D rBody;
    public bool isJumping = false;
    private Animator animator;
    private float jumpInput;
    private float horizontalInput;
    private float originalSpeed;

    public float originalJump;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerSprite = GetComponent<SpriteRenderer>();
        rBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        originalSpeed = speed;
        originalJump = jumpSpeed;
    }

    void Update()
    {
        jumpInput = Input.GetAxis("Jump");
        horizontalInput = Input.GetAxis("Horizontal");
        var halfHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
        groundCheck = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - halfHeight - 0.04f), Vector2.up, 0.025f);
            //animator.SetFloat("DireccaoX", horizontalInput);
    }

    void FixedUpdate()
    {


        if (horizontalInput < 0f || horizontalInput > 0f)
        {
            //animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
            playerSprite.flipX = horizontalInput < 0f;
            if (isSwinging)
            {

                if (!isJumping)
                {

                    var groundForce = speed * 2f;
                   // Debug.Log(groundForce);
                    Vector2 v = new Vector2((horizontalInput * groundForce - rBody.velocity.x) * groundForce, 0);
                   // Debug.Log(v);
                    rBody.AddForce(v);
                    rBody.velocity = new Vector2(rBody.velocity.x, rBody.velocity.y);
                //    Debug.Log(rBody.velocity);
                }
                else {
                
                //animator.SetBool("IsSwinging", true);

                // Get normalized direction vector from player to the hook point
                var playerToHookDirection = (ropeHook - (Vector2)transform.position).normalized;

                // Inverse the direction to get a perpendicular direction
                Vector2 perpendicularDirection;
                if (horizontalInput < 0)
                {
                    perpendicularDirection = new Vector2(-playerToHookDirection.y, playerToHookDirection.x);
                    var leftPerpPos = (Vector2)transform.position - perpendicularDirection * -2f;
                    Debug.DrawLine(transform.position, leftPerpPos, Color.green, 0f);
                }
                else
                {
                    perpendicularDirection = new Vector2(playerToHookDirection.y, -playerToHookDirection.x);
                    var rightPerpPos = (Vector2)transform.position + perpendicularDirection * 2f;
                    Debug.DrawLine(transform.position, rightPerpPos, Color.green, 0f);
                }

                var force = perpendicularDirection * swingForce;
                rBody.AddForce(force, ForceMode2D.Force);
                }
            }
            else
            {
                //animator.SetBool("IsSwinging", false);
                var groundForce = speed * 2f;
                Vector2 v = new Vector2((horizontalInput * groundForce - rBody.velocity.x) * groundForce, 0);
                rBody.AddForce(v);
                rBody.velocity = new Vector2(rBody.velocity.x, rBody.velocity.y);
            }
        }
        else
        {
            //animator.SetBool("IsSwinging", false);
            //animator.SetFloat("Speed", 0f);
        }

        if (!isSwinging)
        {
            //if (!groundCheck) return;

            //isJumping = jumpInput > 0f;
            if (isJumping && jumpInput > 0f)
            {
                
                rBody.velocity = new Vector2(rBody.velocity.x, jumpSpeed);
                isJumping = false;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = true;
        if (collision.gameObject.layer == 12)
       
        {
            groundCheck = true;
            isJumping = true;
            //unSlow();
            
        }

        if (collision.gameObject.tag == "Enemy") {
            gameManager.FailedLevel();
        }

        if (collision.gameObject.layer == 13)// fim
        {
            gameManager.CompleteLevel();
        }

        //if (collision.gameObject.tag == "Slower")
        // slowByHalf();

    }

    private void unSlow()
    {
        speed = originalSpeed;
    }

    private void slowByHalf()
    {
        speed = originalSpeed / 2;

    }

    void OnParticleCollision(GameObject other)
    {
        slowByHalf();
    }
}
