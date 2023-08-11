using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject applePie;
    public Animator endNote;
    void Update()
    {
        if (applePie.IsDestroyed())
        {
            endNote.SetBool("isOpen", true);
        } 
    }
}
