using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,target.transform.position,0.02f);
    }

    void OnTriggerEnter(Collider collision)
    {
        if ((collision.gameObject.tag == "CloneLaser") || (collision.gameObject.tag == "Explosion"))
        {
            Destroy(Enemy.gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Debug.Log ("TEST11111");
        }
    }
}
