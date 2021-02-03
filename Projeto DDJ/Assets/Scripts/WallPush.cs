using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPush : MonoBehaviour
{
    private GameObject player;
    private List<GameObject> walls;
    private int movement_multiplier = 1;
    private float speed = 0.2f;
    private bool canPush = true;

    /** 0 -> moving to player; 1 -> comming back */
    private int count_controller;

    void Start()
    {
        player = GameObject.Find("Player");
        walls = new List<GameObject>();
        count_controller = 0;
    }

    void Update()
    {
        if (walls.Count > 0 && (walls[0].transform.position.x < -20 || walls[0].transform.position.x > 20))
        {
            foreach (GameObject wall in walls)
            {
                Destroy(wall);
            }
            walls.Clear();
            Destroy(gameObject);
        }
        float xPos = player.transform.position.x;
        foreach (GameObject wall in walls)
        {
            wall.transform.Translate(
                (new Vector3(xPos, wall.transform.position.y, wall.transform.position.z) - wall.transform.position)
                .normalized * speed * movement_multiplier);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && canPush)
        {
            canPush = false;
            StartPushWall();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (count_controller == 0)
            {
                movement_multiplier = -1;
                count_controller = 1;
            }
            else
            {
                movement_multiplier = 1;
                count_controller = 0;
            }
        }
    }

    private void StartPushWall()
    {
        Collider2D[] allOverlappingColliders = new Collider2D[10];
        Collider2D col2d = gameObject.GetComponent<Collider2D>();

        ContactFilter2D contactFilter = new ContactFilter2D();

        int overlapCount = Physics2D.OverlapCollider(col2d, contactFilter, allOverlappingColliders);

        for (int i = 0; i < overlapCount; i++)
        {
            if (allOverlappingColliders[i].gameObject.tag == "Wall")
            {
                GameObject movingWall = Instantiate(allOverlappingColliders[i].gameObject, 
                    allOverlappingColliders[i].gameObject.transform.position, Quaternion.identity) as GameObject;

                walls.Add(movingWall);
            }
        }
    }
}
