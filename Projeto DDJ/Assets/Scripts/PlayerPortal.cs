using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPortal : MonoBehaviour
{

    public Transform crosshair;
    public SpriteRenderer crosshairSprite;
    public GameObject objectToBeCreated;
    private float distance;
    private GameObject obj;
    public float platformTimer = 3f; 
    // Start is called before the first frame update
    void Start()
    {
        distance = GameObject.Find("Player") .GetComponent<PlayerHook>().ropeMaxCastDistance;
    }

    // Update is called once per frame
    void Update()
    {

        var worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
        var facingDirection = worldMousePosition - transform.position;
        var aimAngle = Mathf.Atan2(facingDirection.y, facingDirection.x);
        if (aimAngle < 0f)
        {
            aimAngle = Mathf.PI * 2 + aimAngle;
        }
        SetCrosshairPosition(aimAngle);
         if (Input.GetKeyDown(KeyCode.Mouse1))
        {
             CreateObject();
             //crosshairSprite.enabled = false;
         }
    }
    

    public void CreateObject(){
       Vector3 position    = new Vector3(crosshair.transform.position.x,crosshair.transform.position.y, -0.5f);
        Quaternion rotation = new Quaternion(0,0,0,0);
        if(obj == null) {
            obj = Instantiate(objectToBeCreated, position, rotation) as GameObject;
            StartCoroutine(ExecuteAfterTime(platformTimer));
        } else
        {
            StopAllCoroutines();
            obj.transform.position = position;
            StartCoroutine(ExecuteAfterTime(platformTimer));
        }
       
        obj.layer = 12;
        obj.GetComponent<SpriteRenderer>().sortingOrder = 1;
        obj.transform.localScale = new Vector3(transform.localScale.x/2,transform.localScale.y/3, 0);
       
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        if(GameObject.Find("Player").GetComponent<PlayerHook>().isRopeAttached())
        {
            GameObject.Find("Player").GetComponent<PlayerHook>().ResetRope();
        }

        Destroy(obj);
    }

    /// <summary>
    /// Move the aiming crosshair based on aim angle
    /// </summary>
    /// <param name="aimAngle">The mouse aiming angle</param>
    private void SetCrosshairPosition(float aimAngle)
    {
        if (!crosshairSprite.enabled)
        {
            crosshairSprite.enabled = true;
        }
      
        var x = transform.position.x + distance * Mathf.Cos(aimAngle);
        var y = transform.position.y + distance * Mathf.Sin(aimAngle);
        var crossHairPosition = new Vector3(x, y, 0);
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        var mousePosition = new Vector3( worldPosition.x, worldPosition.y, 0);
        var distMouse = Vector3.Distance(mousePosition,transform.position);
        if(distMouse < distance)
                crosshair.transform.position = mousePosition;
                else
                {
                    crosshair.transform.position = crossHairPosition;
                }
        
    }
}
