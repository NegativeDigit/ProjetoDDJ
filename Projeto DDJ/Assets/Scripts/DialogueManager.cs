using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    public Text dialogueText;

    private Dialogue dialogue;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    public void StartDialogue(Dialogue dialogue)
    {
        this.dialogue = dialogue;
        //nameText.text = dialogue.name;
        //dialogueText = newDialogueText;
        sentences = new Queue<string>();
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
            Debug.Log("sssss");
            Text b = GameObject.Find("Continue_Button").transform.GetChild(0).gameObject.GetComponent<Text>();
            b.text = "Continue";
            EndDialogue();

            return;
        }
        if (sentences.Count == 1)
        {
           Text b =  GameObject.Find("Continue_Button").transform.GetChild(0).gameObject.GetComponent<Text>();
            b.text = "Restart";
        }
        
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    private void EndDialogue()
    {
        StartDialogue(dialogue);
    }
}
