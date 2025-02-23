using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader03 : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        Debug.Log("Button clicked! Attempting to load scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
    
}
