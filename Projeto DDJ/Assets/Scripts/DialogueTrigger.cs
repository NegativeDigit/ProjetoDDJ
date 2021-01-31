using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    private Dialogue dialogue;

    public void TriggerDialogue1()
    {
        dialogue = new Dialogue
        {
            name = "name",
            sentences = new string[5]
        };
        dialogue.sentences[0] = "0";
        dialogue.sentences[1] = "1";
        dialogue.sentences[2] = "2";
        dialogue.sentences[3] = "3";
        dialogue.sentences[4] = "Movements:\n   A - Left\n   D - Right\n   SPACE - Jump";
    
        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void TriggerDialogue2()
    {
        dialogue = new Dialogue
        {
            name = "name",
            sentences = new string[5]
        };
        dialogue.sentences[0] = "In order to get through you must your weapons";
        dialogue.sentences[1] = "Right Button to create a plataform";
        dialogue.sentences[2] = "Left Button to hook into a plataform";
        dialogue.sentences[3] = "Up button to climb";
        dialogue.sentences[4] = "Now just swing";

        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
