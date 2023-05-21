using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject target;
    double y;
    public GameObject Car;
    //GameObject cloneObject;
    //public GameObject RndSign;
    Vector3 tmp;
    //Transform a;

    // Start is called before the first frame update
    void Start()
    {   
        //a = 0;

        //while(a < 20)
        //{
            //rnd = UnityEngine.Random.Range(1, 49);
            //RndSign = GameObject.Find(("Sign")(rnd));

            //++a;
        //}
        transform.position = new Vector3(14,2,71);
    }

    // Update is called once per frame
    void Update()
    {
        //いったん保留
        //transform.position = Vector3.MoveTowards(transform.position,target.transform.position,0.02f);
        //a = Car.transform.eulerAngles.y + 90.0f;
        this.transform.LookAt(Car.transform);
        Transform myTransform = this.transform;
        Vector3 worldAngle = myTransform.eulerAngles;
        worldAngle.x -= 90.0f;
        myTransform.eulerAngles = worldAngle;

        tmp = gameObject.GetComponent<Transform>().position;
        y = tmp.y;

        if(y <= -10)
        {

        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if ((collision.gameObject.tag == "CloneLaser") || (collision.gameObject.tag == "Explosion"))
        {
            Destroy(Enemy.gameObject);
        }

    }

    //private void OnCollisionEnter(Collision collision)
    //{
        //if(collision.gameObject.tag == "Wall")
        //{
            //Debug.Log ("TEST11111");
        //}
    //}
}
