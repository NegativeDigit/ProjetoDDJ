﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
      
        if (collision.gameObject.tag.Equals("Falling_Obstacle"))
        {
            Debug.Log(obj);
            Destroy(obj);
        }
    }

    public void setObject(GameObject obj)
    {
        this.obj = obj;
    }
}
