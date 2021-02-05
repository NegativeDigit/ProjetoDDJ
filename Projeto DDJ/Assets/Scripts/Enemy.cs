using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (SceneManager.GetActiveScene().name.Equals("Ice_Level")) {
            GameObject.Find("FallBlock").GetComponent<EdgeCollider2D>().enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player")) {
            gameManager.FailedLevel();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            gameManager.FailedLevel();
        }
    }
}
