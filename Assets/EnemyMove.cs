using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if ((collision.gameObject.tag == "CloneLaser") || (collision.gameObject.tag == "Explosion"))
        {
            Destroy(Enemy.gameObject);
        }

    }
}
