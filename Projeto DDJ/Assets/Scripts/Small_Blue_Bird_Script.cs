using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_Blue_Bird_Script : MonoBehaviour
{

    public Transform player;
    public GameObject smallBlueBird;
    public GameObject blueBird;
    public float speed = 20f;
    public int maxDistance = 50;
    public int lifeTime = 500;
    public int count;
    private Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        target = player.position-((blueBird.transform.position-player.position)*5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        smallBlueBird.transform.position = Vector2.MoveTowards(smallBlueBird.transform.position, target, speed * Time.deltaTime);
        if(count == lifeTime)
        {
            Destroy(smallBlueBird);
        }
        count++;

        Physics2D.IgnoreCollision(smallBlueBird.GetComponent<CircleCollider2D>(), blueBird.GetComponent<EdgeCollider2D>());
        Physics2D.IgnoreCollision(smallBlueBird.GetComponent<CircleCollider2D>(), GameObject.Find("Floor").GetComponent<BoxCollider2D>());
    }
}
