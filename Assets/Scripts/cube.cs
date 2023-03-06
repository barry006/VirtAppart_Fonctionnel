using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
   
    public int speed=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * -transform.forward * speed;

        /*
        if (transform.position.z < -50 || transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        */

    }
}
