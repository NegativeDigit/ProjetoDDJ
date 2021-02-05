using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSkyLevel : MonoBehaviour
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

    private bool setToCorridor;
    [SerializeField] Transform CorridorCenter;

    public Vector3 boundsMax;
    public Vector3 boundsMin;
    void Update()
    {
        
        Vector3 startPos = this.gameObject.transform.position;
        Vector3 endPos = player.transform.position;

        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -10;

        this.gameObject.transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);
        this.gameObject.transform.position = new Vector3
            (
            Mathf.Clamp(this.gameObject.transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(this.gameObject.transform.position.y, bottomLimit, topLimit),
            transform.position.z
            );

            //transform.position = new Vector3 (Mathf.Clamp (transform.position.x, boundsMin.x, boundsMax.x), Mathf.Clamp (transform.position.y, boundsMin.y, boundsMax.y), Mathf.Clamp (transform.position.z, boundsMin.z, boundsMax.z));
       
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

    internal void setCameraToCorridor()
    {
        Debug.Log("Camera Change");
        this.gameObject.transform.position = CorridorCenter.position;
        this.gameObject.transform.rotation = CorridorCenter.rotation;
        this.gameObject.transform.localScale = CorridorCenter.localScale;
        setToCorridor = true;
    }

    internal void setCameraToPlayer()
    {
        setToCorridor = false;
    }
}
