using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position -= 0.1f * this.gameObject.transform.forward;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Plane")
        {
            Destroy(gameObject);
        }
    }

}
