using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject target;
    double y;
    GameObject cloneObject;
    public GameObject RndSign;
    Vector3 tmp;
    int a;

    // Start is called before the first frame update
    void Start()
    {   
        //a = 0;

        //while(a < 20)
        //{
            //rnd = UnityEngine.Random.Range(1, 49);
            //RndSign = GameObject.Find(("Sign")(rnd));
            Transform SignTransform = RndSign.transform;
            Vector3 pos = SignTransform.position;
            Vector3 worldAngle = SignTransform.eulerAngles;
            cloneObject = Instantiate(Enemy, pos, Quaternion.identity);
            cloneObject.transform.eulerAngles = worldAngle;

            //++a;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,target.transform.position,0.02f);

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
