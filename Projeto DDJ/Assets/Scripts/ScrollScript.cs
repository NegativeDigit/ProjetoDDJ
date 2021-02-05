using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject canvas;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
        GameObject x = GameObject.Find("ScrollCanvas");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) { 
            gameObject.SetActive(false);
            canvas.SetActive(true);
            player.GetComponent<PlayerMovement>().enabled = false;

        }
    }

    public void AllowWeapons()
    {
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<PlayerHook>().enabled = true;
        player.GetComponent<PlayerPortal>().enabled = true;
        canvas.SetActive(false);
    }
}
