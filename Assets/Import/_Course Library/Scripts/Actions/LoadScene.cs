using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Load scene using name, or reload the active scene
/// </summary>
public class LoadScene : MonoBehaviour
{
    public void OOO_LoadSceneUsingName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OOO_ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void OOO_LoadNextSceneIncrement(int i)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + i);
   
    }

    public void OOO_LoadWithIdex(int i)
    {
        SceneManager.LoadScene(i);
   
    }     
}
