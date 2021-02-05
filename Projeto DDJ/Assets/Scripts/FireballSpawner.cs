using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    private float timer_delay = 3;
    public GameObject fireball;

    private float yOffset = 20; //camera size (10) + 10

    void Update()
    {
        timer_delay -= Time.deltaTime;
        if (timer_delay <= 0f)
        {
            float xpos = Random.Range(-40, 40);
            float yPos = Camera.main.transform.position.y + yOffset;

            Vector3 spawn_position = new Vector3(xpos, yPos, 0);

            Instantiate(fireball, spawn_position, Quaternion.identity);
            timer_delay = 2f;
        }
    }
}
