
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DesactiveMobilier : MonoBehaviour
{
    public GameObject _mobilier;
    public InputActionReference Oooo;
    public InputActionReference uuu;
    bool b = true;
    [SerializeField] string OtherSceneName = "";

    private void OnEnable()
    {
        Oooo.action.performed += context =>
        {
            if (_mobilier != null && _mobilier)
            {
                _mobilier.SetActive(b = !b);
            }
        };
        Oooo.action.Enable();

        uuu.action.performed += context => NextScene();
        uuu.action.Enable();
    }

    private void OnDisable()
    {
        Oooo.action.performed -= context =>
        {
            if (_mobilier != null && _mobilier)
            {
                _mobilier.SetActive(b = !b);
            }
        };
        uuu.action.performed -= context => NextScene();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(OtherSceneName);
    }
}

