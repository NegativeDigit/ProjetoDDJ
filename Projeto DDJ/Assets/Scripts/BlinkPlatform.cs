using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkPlatform : MonoBehaviour
{
    public float waitTime = 0;
    public float lifeTime = 3 - 0.4f;
    public float deadTime = 3;
    private bool isAlive = true;
    private bool hasStarted = false;

    private float currentTimer;

    void Start()
    {
        if (waitTime > 0)
        {
            renderChildren(false);
            allowChildrenColliders(false);
            currentTimer = deadTime;
        }
        currentTimer = lifeTime;
        StartCoroutine(WaitToStart());
    }

    void Update()
    {
        if (hasStarted)
        {
            currentTimer -= Time.deltaTime;
            if (currentTimer <= 0f)
            {
                if (isAlive)
                {
                    StartCoroutine(BlinkTimer());
                }
                else
                {
                    renderChildren(true);
                    allowChildrenColliders(true);
                    isAlive = true;
                    currentTimer = lifeTime;
                }
            }
        }    
    }

    private void renderChildren(bool value)
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.GetComponent<Renderer>().enabled = value;
        }
    }

    private void allowChildrenColliders(bool value)
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.GetComponent<Collider2D>().enabled = value;
        }
    }

    private IEnumerator BlinkTimer()
    {
        renderChildren(false);
        yield return new WaitForSeconds(0.2f);
        renderChildren(true);
        yield return new WaitForSeconds(0.2f);
        renderChildren(false);
        allowChildrenColliders(false);
        isAlive = false;
        currentTimer = deadTime;
    }

    private IEnumerator WaitToStart()
    {
        yield return new WaitForSeconds(waitTime);
        if (!isAlive || waitTime > 0)
        {
            renderChildren(true);
            allowChildrenColliders(true);
        }
        hasStarted = true;
    }
}
