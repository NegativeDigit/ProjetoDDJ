using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yeti : Enemy
{
    [SerializeField] private GameObject spike;
    private float currentTimeUp;
    private float currentTimeDown;
    private float currentTimeMiddle;
    private float currentTimeTop;
    public float upTimer = 1.5f;
    public float middleTimer = 0.5f;
    public float downTimer = 2.5f;
    public float topTimer = 3.5f;
    [SerializeField] private int thrust;
    private bool entered = false;

// Update is called once per frame
void Update()
{
        if (entered)
        {
            currentTimeUp += Time.deltaTime;
            currentTimeDown += Time.deltaTime;
            currentTimeMiddle += Time.deltaTime;
            currentTimeTop += Time.deltaTime;
            if (upTimer - currentTimeUp < 0.001)
            {

                throwSpike(1);
                currentTimeUp = 0;
            }
            if (middleTimer - currentTimeMiddle < 0.001)
            {
                throwSpike(0);
                currentTimeMiddle = 0;
            }

            if (downTimer - currentTimeDown < 0.001)
            {
                throwSpike(-1);
                currentTimeDown = 0;
            }

            if (topTimer - currentTimeTop < 0.001)
            {
                throwSpike(3);
                currentTimeTop = 0;
            }
        }

    }

    void throwSpike(int height) {
        GameObject x = Instantiate(spike);
        Debug.Log(x.transform.position.x);
        x.transform.position = new Vector3(this.transform.position.x+2,this.transform.position.y + height,
            this.transform.position.z);
        
        x.GetComponent<Rigidbody2D>().AddForce(new Vector2(1,0) * thrust);
        x.AddComponent<Ice_Spikes>();
        x.transform.SetParent(this.gameObject.transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        entered = true;
    }


    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        if (collision.gameObject.tag.Equals("Falling_Obstacle")) {
            Destroy(this.gameObject);
        }
    }

}
