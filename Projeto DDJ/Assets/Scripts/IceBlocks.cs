using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlocks : MonoBehaviour
{
    private Rigidbody2D rb;
    [Header("Info")]
    private Vector3 _startPos;
    private Vector3 _randomPos;

    [Header("Settings")]
    [Range(0f, 2f)]
    public float _distance = 0.1f;
    void Start()
    {
        _startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            StopAllCoroutines();
            StartCoroutine(Shake());
        }
    }

    private IEnumerator Shake()
    {

            _randomPos = _startPos + (Random.insideUnitSphere * _distance);

            transform.position = _randomPos;
            yield return new WaitForSeconds((float)0.5);
                rb.isKinematic = false;
    }
}
