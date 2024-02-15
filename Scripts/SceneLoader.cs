using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneIndexToLoad = 2;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E)||Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            
            SceneManager.LoadScene(sceneIndexToLoad);
        }
    }
}
