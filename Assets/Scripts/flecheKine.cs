using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flecheKine : MonoBehaviour
{
    public Rigidbody rb;
    public Collider col;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    private void OnTriggerEnter(Collider other)
    {
        rb.isKinematic = true;
    }

    public void reinitialise()
    {
        Debug.Log("reinitialise");
        rb.isKinematic = false;     
    }
}
