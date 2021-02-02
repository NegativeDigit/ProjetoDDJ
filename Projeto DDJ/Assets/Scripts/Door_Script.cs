using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Script : MonoBehaviour
{

    public Transform door;
    public Transform player;
    private Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(door.position.x, door.position.y+7);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.x > door.position.x+3)
        {
            door.position = Vector2.MoveTowards(door.position, target, 1);
        }
    }
}
