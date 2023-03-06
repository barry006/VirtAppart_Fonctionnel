using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExampleClass1 : MonoBehaviour
{
    private float timePass = 0.0f;
    private int updateCount = 0;

    void Start()
    {
        Debug.Log("Start1");
    }

    // code that generates a message every second
    void Update()
    {
        timePass += Time.deltaTime;
       
        if (timePass > 1.0f)
        {
            timePass = 0.0f;
            Debug.Log("Update1: " + updateCount);
            updateCount = updateCount + 1;
        }
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 250, 60), "Change to scene2"))
        {
            Debug.Log("Exit1");
            SceneManager.LoadScene(1);
        }
    }

    // generate a message before the Start() function
    void OnEnable()
    {
        Debug.Log("OnEnable1");
    }

    // generate a message when the game shuts down or switches to another Scene
    // or switched to ExampleClass2
    void OnDestroy()
    {
        Debug.Log("OnDestroy1");
    }
}