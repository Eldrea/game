using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public Transform g1, g2;
    
    void LoadScene()
    {
        if (g1.position.x >= g2.position.x)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void Update()
    {
        LoadScene();
    }

}