using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public Dialogue[] dialogues;
    public Quests quests;
    
    public void TriggerDialogue()
    {
        if (quests.quantityOfQuest < dialogueManager.quantityDialogueForNP)
        {
            dialogueManager.StartDialogue(dialogues[quests.quantityOfQuest]);

            if (quests.quantityOfQuest == dialogues.Length - 1)
            {
                quests.quantityOfQuest++;
            }
        }
    }
}
