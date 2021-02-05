using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string charName;

    [TextArea(3,10)]
    public string[] sentences;
    // Update is called once per frame
    void Update()
    {
        
    }
}
