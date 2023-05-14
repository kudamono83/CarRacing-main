using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySub : MonoBehaviour
{
    private float time;
    private int rndX;
    private int rndZ;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position　= Enemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        time -= Time.deltaTime;
        if(time <= 0.0f)
        {
            pos　= Enemy.transform.position;
            pos.y -= 1.00f;
            myTransform.position = pos;
            rndX = Random.Range(-30,30);
            rndZ = Random.Range(-30,30);
            transform.position += new Vector3(rndX/10,0,rndZ/10);
            time = 2.0f;
        }
    }
}
