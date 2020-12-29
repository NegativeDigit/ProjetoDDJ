using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D player) {
        if(player.gameObject.layer ==14){
            GameObject.Find("GameManager").GetComponent<GameManager>().FailedLevel();
        }

        if(player.gameObject.layer ==13){
            GameObject.Find("GameManager").GetComponent<GameManager>().CompleteLevel();
        }
    }
}
