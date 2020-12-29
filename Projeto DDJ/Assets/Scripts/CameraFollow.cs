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
        if(player.position.x >  boundsMin.x  && player.position.x <  boundsMax.x-10)
         transform.position = new Vector3 (player.position.x, transform.position.y, transform.position.z);
        if(player.position.y >  boundsMin.y && player.position.y <  boundsMax.y-10)
        transform.position = new Vector3 (transform.position.x, player.position.y, transform.position.z);
        
         //transform.position = new Vector3 (Mathf.Clamp (transform.position.x, boundsMin.x, boundsMax.x), Mathf.Clamp (transform.position.y, boundsMin.y, boundsMax.y), Mathf.Clamp (transform.position.z, boundsMin.z, boundsMax.z));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


}
