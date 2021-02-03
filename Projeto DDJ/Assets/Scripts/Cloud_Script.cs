using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Script : MonoBehaviour
{

    public Rigidbody2D cloud;
    public Rigidbody2D player;
    public float speed = 2.0f;
    private bool direction;
    private int count;
    public int maxCount = 10;
    public bool vertical = false;

    void Start()
    {
        direction = true;
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (direction == true && count <= maxCount)
        {
            if (vertical)
            {
                cloud.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else
            {
                cloud.transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            count++;
        }
        else if (direction == false && count <= maxCount)
        {
            if (vertical)
            {
                cloud.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            else
            {
                cloud.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            count++;
        }
        else
        {
            count = 0;
            if (direction == true)
            {
                direction = false;
            }
            else
            {
                direction = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
            GameObject.Find("GameManager").GetComponent<GameManager>().FailedLevel();
    }
}
