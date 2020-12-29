using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject levelCompleteUI;
    public GameObject levelFailedUI;
    public GameObject player;
    public GameObject lower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CompleteLevel(){
        levelCompleteUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        DeathFallFunction();
    }

    void DeathFallFunction()
    {
        if(player.transform.position.y <= lower.transform.position.y - 10)
        {
            FailedLevel();
        }
    }

    public void FailedLevel(){
        levelFailedUI.SetActive(true);
    }
}
