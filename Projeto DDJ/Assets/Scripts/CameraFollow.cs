using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    void Update () 
    {
        transform.position = new Vector3 (player.position.x, player.position.y+2, player.position.z-3); // Camera follows the player but 6 to the right
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


}
