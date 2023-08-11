using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogueManager dm;
    public Quests quests;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (dm.quantityDialogueForNP != quests.quantityOfQuest)
        {
            startAnim.SetBool("isStartOpen", true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        startAnim.SetBool("isStartOpen", false);
        dm.EndDialogue();
    }
}
