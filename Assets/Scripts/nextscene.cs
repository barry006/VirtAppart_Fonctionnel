using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    [SerializeField] Light lighting;
    // Conservez l'objet d'éclairage lors du changement de scéne
    
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
