using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{

    public Rigidbody2D bird;
    public Rigidbody2D player;
    public float speed = 5.0f;
    public float acceptedDist = 30;

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(bird.transform.position, player.transform.position);
        if(distance < acceptedDist)
            bird.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
