using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Bird_Script : MonoBehaviour
{
    public GameObject blueBird;
    public GameObject smallBlueBird;
    private GameObject obj;
    public Transform player;
    public int timer = 4000;
    private int count;
    public float acceptedDist = 30;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float distance = Vector2.Distance(blueBird.transform.position, player.position);
        if (distance < acceptedDist)
        {
            if (count == 0)
            {
                CreateObject();
                count++;
            }
            else
            {
                if (count < timer)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
        }
    }

    public void CreateObject()
    {
        Vector3 position = blueBird.transform.position;
        Quaternion rotation = new Quaternion(0, 0, 0, 0);

        obj = Instantiate(smallBlueBird, position, rotation) as GameObject;

        obj.tag = "Bird";
        obj.AddComponent<Small_Blue_Bird_Script>();
        obj.GetComponent<Small_Blue_Bird_Script>().player = player;
        obj.GetComponent<Small_Blue_Bird_Script>().smallBlueBird = obj;
        obj.GetComponent<Small_Blue_Bird_Script>().blueBird = blueBird;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && isAlive)
            GameObject.Find("GameManager").GetComponent<GameManager>().FailedLevel();

    }
}
