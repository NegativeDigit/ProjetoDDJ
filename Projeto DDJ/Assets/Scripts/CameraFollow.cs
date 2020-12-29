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
        if(player.position.x >  8  && player.position.x <  GameObject.Find("background3").transform.position.x-20)
         transform.position = new Vector3 (player.position.x, transform.position.y, transform.position.z);
        if(player.position.y >  GameObject.Find("background0").transform.position.y && player.position.y <  GameObject.Find("background3").transform.position.y)
        transform.position = new Vector3 (transform.position.x, player.position.y, transform.position.z);
        
         //transform.position = new Vector3 (Mathf.Clamp (transform.position.x, boundsMin.x, boundsMax.x), Mathf.Clamp (transform.position.y, boundsMin.y, boundsMax.y), Mathf.Clamp (transform.position.z, boundsMin.z, boundsMax.z));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


}
