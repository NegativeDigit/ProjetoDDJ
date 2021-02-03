using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    Vector2 posOffset;

    [SerializeField]
    float timeOffset;

    [SerializeField]
    float leftLimit;

    [SerializeField]
    float rightLimit;

    [SerializeField]
    float topLimit;

    [SerializeField]
    float bottomLimit;

    public Vector3 boundsMax;
    public Vector3 boundsMin;
    void Update () 
    {
        if (player.transform.position.y > 5.133107) { 
            leftLimit = (float)-23.24006;
            bottomLimit = (float)-1.796795;
        }
        Vector3 startPos = transform.position;
        Vector3 endPos = player.transform.position;

        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -10;

        transform.position = Vector3.Lerp(startPos, endPos, timeOffset*Time.deltaTime);
        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, bottomLimit, topLimit),
            transform.position.z
            );
     
        transform.position = new Vector3 (Mathf.Clamp (transform.position.x, boundsMin.x, boundsMax.x), Mathf.Clamp (transform.position.y, boundsMin.y, boundsMax.y), Mathf.Clamp (transform.position.z, boundsMin.z, boundsMax.z));
    }

    public float getBottomValue()
    {
        return bottomLimit;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }


}
