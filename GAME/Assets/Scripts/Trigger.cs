using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public Dialogue dialogue;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Wall")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        if (collision.name == "Friend")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogue.ActivateDialogue();
            }
        }
    }

}