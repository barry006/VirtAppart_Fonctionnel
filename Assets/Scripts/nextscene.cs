using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    [SerializeField] Light lighting;
    // Conservez l'objet d'�clairage lors du changement de sc�ne
    
    [SerializeField] string OtherSceneName;

    private void Awake()
    {
      DontDestroyOnLoad(lighting);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(OtherSceneName);
    }
}
