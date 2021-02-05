using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    private GameObject player;
    // Start is called before the first frame update

    void Awake()
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<PlayerHook>().enabled = false;
        player.GetComponent<PlayerPortal>().enabled = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void allowMovement()
    {
        player.GetComponent<PlayerMovement>().enabled = true;
        //player.GetComponent<PlayerHook>().enabled = true;
       // player.GetComponent<PlayerPortal>().enabled = true;
        gameObject.SetActive(false);
    }
}
