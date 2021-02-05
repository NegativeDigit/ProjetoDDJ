using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelScript : MonoBehaviour
{
    public void SkyLevel()
    {
        SceneManager.LoadScene("Air_Level");
    }
}
