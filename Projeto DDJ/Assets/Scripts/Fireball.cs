using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private float yOffset;
    private float xOffset;
    private Vector3 direction;
    private GameObject player;

    private float projectileSpeed;

    void Start()
    {
        xOffset = Random.Range(-20, 20);
        yOffset = Random.Range(-10, 10);

        player = GameObject.Find("Player");

        Vector3 position_offset = new Vector3(player.transform.position.x + xOffset,
            player.transform.position.y + yOffset, player.transform.position.z);

        direction = (position_offset - gameObject.transform.position).normalized;

        //Look at player
        float rot_z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z + 90);

        projectileSpeed = 5;
    }

    void FixedUpdate()
    {
        gameObject.transform.position += direction * projectileSpeed * Time.deltaTime;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
