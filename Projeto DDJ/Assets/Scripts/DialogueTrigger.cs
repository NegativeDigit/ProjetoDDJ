using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private Queue<string> sentences;

    public Text dialogueText;


    void Awake()
    {

        StartDialogue(dialogue);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        this.dialogue = dialogue;
        //nameText.text = dialogue.name;
        //dialogueText = newDialogueText;
        sentences = new Queue<string>();
        sentences.Clear();
        foreach (string i in dialogue.sentences)
        {
            sentences.Enqueue(i);
        }
        if(sentences.Count == 1)
        {

        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            Text b = transform.GetChild(2).transform.GetChild(0).gameObject.GetComponent<Text>();
            b.text = "Continue";
            EndDialogue();

            return;
        }
        if (sentences.Count == 1)
        {
            Text b = transform.GetChild(2).transform.GetChild(0).gameObject.GetComponent<Text>();
            //= this.ToString .Find("Continue_Button").transform.GetChild(0).gameObject.GetComponent<Text>();
            b.text = "Restart";
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    private void EndDialogue()
    {
        StartDialogue(dialogue);
    }


    //    public void TriggerDialogue1()
    //{


    //    gameObject.SetActive(false);// open button


    //    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    //}

    //public void TriggerDialogue2()
    //{
    //    text.AddComponent<Dialogue>();
    //    text.GetComponent<Dialogue>().sentences = new string[3];
    //    text.GetComponent<Dialogue>().sentences[0] = "And the world was at peace.";
    //    text.GetComponent<Dialogue>().sentences[1] = "Until the dragons disappeared.";
    //    text.GetComponent<Dialogue>().sentences[2] = "All except one.";

    //    gameObject.SetActive(false);// open button


    //    FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>(), dialogueText);
    //}

    //public void TriggerDialogue3()
    //{
    //    text.AddComponent<Dialogue>();
    //    text.GetComponent<Dialogue>().charName = "name";
    //    text.GetComponent<Dialogue>().sentences = new string[4];

    //    text.GetComponent<Dialogue>().sentences[0] = "Shun, son of the Dragon King of the South, found himself mysteriously weakened, his powers stripped away from him.";
    //    text.GetComponent<Dialogue>().sentences[1] = "Shun searched far and wide for an explanation to what happened, but being unable to turn into his true dragon form made his travels long and hard.";
    //    text.GetComponent<Dialogue>().sentences[2] = "After days of searching, he reached a certain temple, and the monks immediately recognized him as the son of the Southern Dragon King.";
    //    text.GetComponent<Dialogue>().sentences[3] = "Shun soon recognized as well where he was. The Temple of the Black Dragon, dedicated to the worship and maintenance of his father and their kingdom.";

    //    gameObject.SetActive(false);// open button


    //    FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>(), dialogueText);
    //}

    //public void TriggerDialogue4()
    //{
    //    text.AddComponent<Dialogue>();
    //    text.GetComponent<Dialogue>().charName = "name";
    //    text.GetComponent<Dialogue>().sentences = new string[5];

    //    text.GetComponent<Dialogue>().sentences[0] = "The monks told Shun everything they knew. The dragons had disappeared over two thousand years ago, and not a single one had been seen since then.";
    //    text.GetComponent<Dialogue>().sentences[1] = "The demons had taken over, but without their Goddess they soon turned on each other, ravishing the land with their fights.";
    //    text.GetComponent<Dialogue>().sentences[2] = "Confused about everything he just heard, Shun asked the monks if they were certain that there was no place that hadn’t been searched yet.";
    //    text.GetComponent<Dialogue>().sentences[3] = "He was determined to find out what happened to the other dragons.";
    //    text.GetComponent<Dialogue>().sentences[4] = "Shun felt fear when he heard their answer.";

    //    gameObject.SetActive(false);// open button


    //    FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>(), dialogueText);
    //}


    //public void TriggerDialogue5()
    //{
    //    text.AddComponent<Dialogue>();
    //    text.GetComponent<Dialogue>().charName = "name";
    //    text.GetComponent<Dialogue>().sentences = new string[8];

    //    text.GetComponent<Dialogue>().sentences[0] = "In order to prepare him for his journey, the monks gave Shun their most sacred possessions.";
    //    text.GetComponent<Dialogue>().sentences[1] = "The very things his father had used in the war with the demons so long ago.";
    //    text.GetComponent<Dialogue>().sentences[2] = "The Black Hook, capable of attaching itself to any foe.";
    //    text.GetComponent<Dialogue>().sentences[3] = "And a scroll containing the technique of summoning a magic platform that stays in the air without falling.";
    //    text.GetComponent<Dialogue>().sentences[4] = "Right Button to create a plataform";
    //    text.GetComponent<Dialogue>().sentences[5] = "Left Button to hook into a plataform";
    //    text.GetComponent<Dialogue>().sentences[6] = "Up button to climb";
    //    text.GetComponent<Dialogue>().sentences[7] = "Now just swing";

    //    gameObject.SetActive(false);// open button


    //    FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>(), dialogueText);
    //}

    //public void TriggerDialogue6()
    //{
    //    text.AddComponent<Dialogue>();
    //    text.GetComponent<Dialogue>().charName = "name";
    //    text.GetComponent<Dialogue>().sentences = new string[5];

    //    text.GetComponent<Dialogue>().sentences[0] = "Shun thanked the monks and readied himself." +
    //        "Stories about how terrifying and dangerous the Demon Goddess was.";
    //    text.GetComponent<Dialogue>().sentences[1] = "He hadn’t been there, thousands of years ago, during the war. He had only heard stories.";
    //    text.GetComponent<Dialogue>().sentences[2] = "Stories about how terrifying and dangerous the Demon Goddess was.";
    //    text.GetComponent<Dialogue>().sentences[3] = "And yet, here he was. About to journey into the last place he ever hoped he had to.";
    //    text.GetComponent<Dialogue>().sentences[4] = "A land of legend, surrounded in mystery and old tales, where no one had set foot since the end of the great war.";

    //    gameObject.SetActive(false);// open button


    //    FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>(), dialogueText);
    //}

    //public void TriggerDialogue7()
    //{
    //    text.AddComponent<Dialogue>();
    //    text.GetComponent<Dialogue>().charName = "name";
    //    text.GetComponent<Dialogue>().sentences = new string[1];

    //    text.GetComponent<Dialogue>().sentences[0] = "The prison on the Demon Goddess, the Lost Continent.";

    //    gameObject.SetActive(false);// open button


    //    FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>(), dialogueText);
    //}
}
