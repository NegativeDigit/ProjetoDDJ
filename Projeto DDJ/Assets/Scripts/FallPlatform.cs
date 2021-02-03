using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatform : MonoBehaviour
{
    private bool canFall = false;
    public float speed = 10f;
    private float initialYPos;
    public float distance = 5f;  

    void Start()
    {
        initialYPos = gameObject.transform.position.y;
    }

    void Update()
    {
        if (canFall)
        {
            gameObject.transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (gameObject.transform.position.y < initialYPos - distance)
        {
            Destroy(gameObject);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canFall = true;
        }
    }
}
