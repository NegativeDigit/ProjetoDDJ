using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> sentences;

    public Text nameText;
    public Text dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue, Text newDialogueText)
    {
        nameText.text = dialogue.name;
        dialogueText = newDialogueText;
        sentences.Clear();
        foreach(String i in dialogue.sentences)
        {
            sentences.Enqueue(i);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        if (sentences.Count == 1)
        {
           Text b =  GameObject.Find("Continue_Button").transform.GetChild(0).gameObject.GetComponent<Text>();
            b.text = "End";
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    private void EndDialogue()
    {
        //GameObject.Find("Dialogue_System").SetActive(false);
    }
}
