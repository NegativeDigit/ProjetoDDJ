using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_Green_Bird_Script : MonoBehaviour
{

    public Transform player;
    public GameObject smallGreenBird;
    public GameObject greenBird;
    public float speed = 7f;
    public int maxDistance = 50;
    public int lifeTime = 500;
    public int count;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        smallGreenBird.transform.position = Vector2.MoveTowards(smallGreenBird.transform.position, player.position, speed * Time.deltaTime);
        if (count == lifeTime)
        {
            Destroy(smallGreenBird);
        }
        count++;

        Physics2D.IgnoreCollision(smallGreenBird.GetComponent<EdgeCollider2D>(), GameObject.Find("Floor").GetComponent<BoxCollider2D>());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && isAlive)
            GameObject.Find("GameManager").GetComponent<GameManager>().FailedLevel();
    }

}
