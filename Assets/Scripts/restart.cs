using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public string st ="";

    void Start()
    {
        
    }

    void Update()
    {

        //     if (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger)==1 && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) == 1)    
   
    }
   public void Onrestart()
    {
        SceneManager.LoadScene(st);
    }
}
