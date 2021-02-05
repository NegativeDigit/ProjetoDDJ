using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{

    public Rigidbody2D bird;
    public Rigidbody2D player;
    public float speed = 5.0f;
    public float acceptedDist = 30;
    public bool isAlive = true;

    // Update is called once per frame
    void FixedUpdate()
    {

        float distance = Vector2.Distance(bird.transform.position, player.transform.position);
        if(distance < acceptedDist)
            bird.transform.Translate(Vector3.left * speed * Time.deltaTime);

        Physics2D.IgnoreCollision(bird.GetComponent<EdgeCollider2D>(), GameObject.Find("Floor").GetComponent<BoxCollider2D>());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && isAlive)
            GameObject.Find("GameManager").GetComponent<GameManager>().FailedLevel();
    }

}
