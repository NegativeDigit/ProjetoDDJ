using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Spikes : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    private Vector3 startPos;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
            rb.isKinematic = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
            GameObject.Find("GameManager").GetComponent<GameManager>().FailedLevel();

        if (collision.gameObject.layer == 12)
        {
            transform.position = startPos;
            rb.isKinematic = true;
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

}
