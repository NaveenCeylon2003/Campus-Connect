using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader04 : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        Debug.Log("Button clicked! Attempting to load scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
