using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public Animator anim;

    public void CloseNote()
    {
        anim.SetBool("isNoteClose", true);
    }
}
