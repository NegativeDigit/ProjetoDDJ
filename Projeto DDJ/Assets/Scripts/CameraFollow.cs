using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 boundsMax;
    public Vector3 boundsMin;
    void Update () 
    {

        transform.position = new Vector3(player.position.x, player.position.y+1.5f, transform.position.z);  
         //transform.position = new Vector3 (Mathf.Clamp (transform.position.x, boundsMin.x, boundsMax.x), Mathf.Clamp (transform.position.y, boundsMin.y, boundsMax.y), Mathf.Clamp (transform.position.z, boundsMin.z, boundsMax.z));
    }
    // Start is called before the first frame update
    void Start()
    {
        //transform.position.
    }


}
