using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
   
    public void pauseee()
    {
        Time.timeScale = 0f;
    }

    public void noPause()
    {
        Time.timeScale = 1f;
    }
}
