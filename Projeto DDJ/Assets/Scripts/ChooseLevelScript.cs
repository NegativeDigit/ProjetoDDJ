using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelScript : MonoBehaviour
{
    public void SkyLevel()
    {
        Debug.Log(SceneManager.sceneCount);
        SceneManager.LoadScene(2);
    }

    public void IceLevel()
    {
        Debug.Log(SceneManager.sceneCount);
        SceneManager.LoadScene(3);
    }

    public void LavaLevel()
    {
        Debug.Log(SceneManager.sceneCount);
        SceneManager.LoadScene(4);
    }

    public void TutorialLevel()
    {
        Debug.Log(SceneManager.sceneCount);
        SceneManager.LoadScene(1);
    }
}
