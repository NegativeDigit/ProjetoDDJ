using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : Enemy
{

    [SerializeField] private GameObject snowball;
    private float currentTime = 0;
    private float ballTimer = 1.8f;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (ballTimer - currentTime < 0.001)
        {
            spawnSnowBall();
            currentTime = 0;
        }

    }

    private void spawnSnowBall() {
        GameObject x = Instantiate(snowball);
        x.transform.position = new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z);
        //x.transform.localScale += new Vector3((float)0.1, (float)0.1, 0);
    }

}
