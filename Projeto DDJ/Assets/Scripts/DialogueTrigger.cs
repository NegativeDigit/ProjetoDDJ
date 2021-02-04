using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject text;

    public void TriggerDialogue1()
    {
        text.AddComponent<Dialogue>(); 
        text.GetComponent<Dialogue>().charName = "name";
        text.GetComponent<Dialogue>().sentences = new string[6];

        text.GetComponent<Dialogue>().sentences[0] = "A long time ago, dragons protected the world.";
        text.GetComponent<Dialogue>().sentences[1] = "They had come together to fight the demons that infested the lands, waging a war that lasted for centuries.";
        text.GetComponent<Dialogue>().sentences[2] = "Dragons and demons battled each other in a never ending cycle of death and rebirth.";
        text.GetComponent<Dialogue>().sentences[3] = "Until it finally came to an end when the four Dragon Kings defeated the Demon Goddess and imprisoned her deep within the Lost Continent.";
        text.GetComponent<Dialogue>().sentences[4] = "The dragons won the war, and the Dragon Kings divided the world in four equal parts, one for each to rule and protect.";
        text.GetComponent<Dialogue>().sentences[5] = "Movements:\n   A - Left\n   D - Right\n   SPACE - Jump";
    
        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>());
    }

    public void TriggerDialogue2()
    {
        text.AddComponent<Dialogue>();
        text.GetComponent<Dialogue>().charName = "name";
        text.GetComponent<Dialogue>().sentences = new string[6];

        text.GetComponent<Dialogue>().sentences[0] = "The demons were forced into hiding, and the dragons roamed the plains, mountains, forests and deserts, ever watching for any dangers that threatened their kingdoms.";
        text.GetComponent<Dialogue>().sentences[1] = "And the world was at peace.";
        text.GetComponent<Dialogue>().sentences[2] = "Until the dragons disappeared.";
        text.GetComponent<Dialogue>().sentences[3] = "All except one.";

        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>());
    }

    public void TriggerDialogue3()
    {
        text.AddComponent<Dialogue>();
        text.GetComponent<Dialogue>().charName = "name";
        text.GetComponent<Dialogue>().sentences = new string[6];

        text.GetComponent<Dialogue>().sentences[0] = "Shun, son of the Dragon King of the South, found himself mysteriously weakened, his powers stripped away from him.";
        text.GetComponent<Dialogue>().sentences[1] = "Shun searched far and wide for an explanation to what happened, but being unable to turn into his true dragon form made his travels long and hard.";
        text.GetComponent<Dialogue>().sentences[2] = "After days of searching, he reached a certain temple, and the monks immediately recognized him as the son of the Southern Dragon King.";
        text.GetComponent<Dialogue>().sentences[3] = "Shun soon recognized as well where he was. The Temple of the Black Dragon, dedicated to the worship and maintenance of his father and their kingdom.";

        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>());
    }

    public void TriggerDialogue4()
    {
        text.AddComponent<Dialogue>();
        text.GetComponent<Dialogue>().charName = "name";
        text.GetComponent<Dialogue>().sentences = new string[6];

        text.GetComponent<Dialogue>().sentences[0] = "The monks told Shun everything they knew. The dragons had disappeared over two thousand years ago, and not a single one had been seen since then. " +
            "The demons had taken over, but without their Goddess they soon turned on each other, ravishing the land with their fights.";
        text.GetComponent<Dialogue>().sentences[1] = "Confused about everything he just heard, Shun asked the monks if they were certain that there was no place that hadn’t been searched yet, " +
            "as he was determined to find out what happened to the other dragons.";
        text.GetComponent<Dialogue>().sentences[2] = "Shun felt fear when he heard their answer.";

        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>());
    }


    public void TriggerDialogue5()
    {
        text.AddComponent<Dialogue>();
        text.GetComponent<Dialogue>().charName = "name";
        text.GetComponent<Dialogue>().sentences = new string[6];

        text.GetComponent<Dialogue>().sentences[0] = "In order to prepare him for his journey, the monks gave Shun their most sacred possessions, the very things his father had used in the war with the demons so long ago. " +
            "The Black Hook, capable of attaching itself to any foe. And a scroll containing the technique of summoning a magic platform that stays in the air without falling.";
        text.GetComponent<Dialogue>().sentences[1] = "Right Button to create a plataform";
        text.GetComponent<Dialogue>().sentences[2] = "Left Button to hook into a plataform";
        text.GetComponent<Dialogue>().sentences[3] = "Up button to climb";
        text.GetComponent<Dialogue>().sentences[4] = "Now just swing";

        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>());
    }

    public void TriggerDialogue6()
    {
        text.AddComponent<Dialogue>();
        text.GetComponent<Dialogue>().charName = "name";
        text.GetComponent<Dialogue>().sentences = new string[6];

        text.GetComponent<Dialogue>().sentences[0] = "Shun thanked the monks and readied himself." +
            "Stories about how terrifying and dangerous the Demon Goddess was.";
        text.GetComponent<Dialogue>().sentences[1] = "He hadn’t been there, thousands of years ago, during the war. He had only heard stories.";
        text.GetComponent<Dialogue>().sentences[2] = "Stories about how terrifying and dangerous the Demon Goddess was.";
        text.GetComponent<Dialogue>().sentences[3] = "And yet, here he was. About to journey into the last place he ever hoped he had to.";
        text.GetComponent<Dialogue>().sentences[4] = "A land of legend, surrounded in mystery and old tales, where no one had set foot since the end of the great war.";

        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>());
    }

    public void TriggerDialogue7()
    {
        text.AddComponent<Dialogue>();
        text.GetComponent<Dialogue>().charName = "name";
        text.GetComponent<Dialogue>().sentences = new string[6];

        text.GetComponent<Dialogue>().sentences[0] = "The prison on the Demon Goddess, the Lost Continent.";

        gameObject.SetActive(false);// open button


        FindObjectOfType<DialogueManager>().StartDialogue(text.GetComponent<Dialogue>());
    }
}
