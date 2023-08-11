using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Animator anim;
    public GameObject frame;
    public GameObject[] otherFrames;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("isButtonOutsideOpen", true);
            frame.SetActive(true);

            foreach (GameObject frame in otherFrames)
            {
                frame.SetActive(false);
            }
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("isButtonOutsideOpen", false);
        }
    }
}
