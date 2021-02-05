using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
    public float rise_speed = 1.5f;

    void Update()
    {
        gameObject.transform.Translate(Vector2.up * rise_speed * Time.deltaTime);
    }
}
