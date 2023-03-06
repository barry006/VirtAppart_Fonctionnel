using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public GameObject[] go;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (go == null)
           Destroy(gameObject);
    }
}
