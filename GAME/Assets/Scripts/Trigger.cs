using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Wall")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
        
    }

}
