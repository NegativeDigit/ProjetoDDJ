using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelScript : MonoBehaviour
{
    public void SkyLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void IceLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void LavaLevel()
    {
        SceneManager.LoadScene(4);
    }

    public void TutorialLevel()
    {
        SceneManager.LoadScene(1);
    }
}
