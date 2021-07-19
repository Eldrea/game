using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogue;

    public void ActivateDialogue()
    {
        Time.timeScale = 0f;
        dialogue.SetActive(true);
    }

    public void DeactivateDialogue()
    {
        Time.timeScale = 1;
        dialogue.SetActive(false);
    }
}
