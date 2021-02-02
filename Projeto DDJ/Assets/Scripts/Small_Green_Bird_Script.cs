using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_Green_Bird_Script : MonoBehaviour
{

    public Transform player;
    public GameObject smallGreenBird;
    public GameObject greenBird;
    public float speed = 5f;
    public int maxDistance = 50;
    public int lifeTime = 500;
    public int count;

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
    }
}
