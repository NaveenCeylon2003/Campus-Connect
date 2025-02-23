using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader05 : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        Debug.Log("Button clicked! Attempting to load scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

}
