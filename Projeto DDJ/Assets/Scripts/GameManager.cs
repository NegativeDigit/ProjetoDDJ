using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private GameObject levelCompleteUI;
    private GameObject levelFailedUI;
    private GameObject player;
    private GameObject plaýer;
  //  private float bottomLimit;
    private Camera camera;
    private float width, height;

    // Start is called before the first frame update
    void Start()
    {
        levelFailedUI = GameObject.Find("Canvas").transform.GetChild(1).gameObject;
        levelCompleteUI = GameObject.Find("Canvas").transform.GetChild(0).gameObject;
        player = GameObject.Find("Player");
        camera = Camera.main;
      //  bottomLimit = camera.GetComponent<CameraFollow>().getBottomValue();
        height = 2f * camera.orthographicSize;
        width = height * camera.aspect;
    }

    public void CompleteLevel(){
        levelCompleteUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(bottomLimit + height / 2);
       /* if (player.transform.position.y + height / 2 < bottomLimit)
        {
            DeathFallFunction();
        }*/


       
    }

    void DeathFallFunction()
    {
        FailedLevel();
    }

    public void FailedLevel(){
        levelFailedUI.SetActive(true);
    }
}
