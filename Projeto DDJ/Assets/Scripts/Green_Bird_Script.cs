using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Bird_Script : MonoBehaviour
{

    public GameObject greenBird;
    public GameObject smallGreenBird;
    private GameObject obj;
    public GameObject player;
    public CapsuleCollider2D boss_Cloud;
    private bool bossStart;
    private bool direction;
    public int directionMaxCount = 500;
    private int directionCount;
    public float speed = 2;
    public int spawnMaxCount = 250;
    private int spawnCount;

    // Start is called before the first frame update
    void Start()
    {
        bossStart = false;
        direction = true;
        directionCount = 0;
        spawnCount = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Physics2D.IsTouching(player.GetComponent<BoxCollider2D>(), boss_Cloud))
        {
            bossStart = true;
        }

        if(bossStart)
        {
            if(greenBird.transform.position.y > 8)
            {
                greenBird.transform.position = Vector2.MoveTowards(greenBird.transform.position, new Vector2(greenBird.transform.position.x, 8.0f), 0.04f);
            } else
            {
                if (direction == true && directionCount <= directionMaxCount)
                {
                    greenBird.transform.Translate(Vector3.left * speed * Time.deltaTime);
                    directionCount++;
                }
                else if (direction == false && directionCount <= directionMaxCount)
                {
                    greenBird.transform.Translate(Vector3.right * speed * Time.deltaTime);
                    directionCount++;
                }
                else
                {
                    directionCount = 0;
                    if (direction == true)
                    {
                        direction = false;
                        greenBird.transform.localScale = new Vector3(-4, 4, 1);
                    }
                    else
                    {
                        direction = true;
                        greenBird.transform.localScale = new Vector3(4, 4, 1);
                    }
                }

                if (spawnCount == 0)
                {
                    CreateObject();
                    spawnCount++;
                }
                else
                {
                    if (spawnCount < spawnMaxCount)
                    {
                        spawnCount++;
                    }
                    else
                    {
                        spawnCount = 0;
                    }
                }
            }

        }
    }

    public void CreateObject()
    {
        Vector3 position = greenBird.transform.position - new Vector3(0, 5, 0);
        Quaternion rotation = new Quaternion(0, 0, 0, 0);

        obj = Instantiate(smallGreenBird, position, rotation) as GameObject;

        if (direction == true)
        {
            obj.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            obj.transform.localScale = new Vector3(-1, 1, 1);
        }

        obj.tag = "Bird";
        obj.AddComponent<Small_Green_Bird_Script>();
        obj.GetComponent<Small_Green_Bird_Script>().player = player.transform;
        obj.GetComponent<Small_Green_Bird_Script>().smallGreenBird = obj;
        obj.GetComponent<Small_Green_Bird_Script>().greenBird = greenBird;
    }
}
