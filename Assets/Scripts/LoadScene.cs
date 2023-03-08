using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] string sceneName;

    public void NextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
