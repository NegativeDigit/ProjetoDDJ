using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player;
    public Transform elevatorSwitch;
    public Transform downpos;
    public Transform upperPos;

    public float speed;
    bool isElevatorDown;

    void Start()
    {
        player = GameObject.Find("Player").transform;
      
    }

    // Update is called once per frame
    void Update()
    {
        startElevator();     
    }


    void startElevator() {
        if (Vector2.Distance(player.position, elevatorSwitch.position) < 1f && Input.GetKeyDown("e"))
        {
            Debug.Log("E detected");
            if (transform.position.y <= downpos.position.y)
            {
                isElevatorDown = true;
                
            }
            else if (transform.position.y >= upperPos.position.y) {
                isElevatorDown = false;
            }

        }

        if (isElevatorDown)
        {
            if (transform.position.y < upperPos.position.y )
            {
                transform.position = Vector2.MoveTowards(transform.position, upperPos.position, speed * Time.deltaTime);

            }
            else {
                Debug.Log("Reached destination");
                isElevatorDown = false;
            }
        }
        else {
            transform.position = Vector2.MoveTowards(transform.position, downpos.position, speed * Time.deltaTime);
        }
    }
}
