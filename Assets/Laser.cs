﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public GameObject car;
    public GameObject Me;
    int LaserNumber;
    CarMove carMove;

    int HowManyTimes2;

    MeshRenderer mesh;

    Vector3 tmp;
    Vector3 dir;

    float x;
    float y;
    float z;
    float x2;
    float y2;
    float z2;

    float px;
    float py;
    float pz;

    // Start is called before the first frame update
    void Start()
    {
        //car = GameObject.Find ("Car");
        carMove = car.GetComponent<CarMove>();

        //x = tmp.x;
        //y = tmp.y;
        //z = tmp.z;
        //tmp = car.transform.position;
        //dir = car.transform.eulerAngles;

        //this.gameObject.SetActive(false);

        //transform.position = new Vector3(0,0,0);

        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = mesh.material.color - new Color32(0,0,0,255);

        HowManyTimes2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LaserNumber = carMove.ItemNumber;

        tmp = car.transform.position;
        dir = Me.transform.eulerAngles;

        x = tmp.x;
        y = tmp.y;
        z = tmp.z;
        x2 = dir.x;
        y2 = dir.y;
        z2 = dir.z;

        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        px = pos.x;
        py = pos.y;
        pz = pos.z;

        //Debug.Log ("AaAaAaAaAa");
        //Debug.Log (LaserNumber);

        if ((Input.GetKeyDown(KeyCode.I)) && (LaserNumber == 4))
        {
            HowManyTimes2 += 1;

            //GameObject cloneLaser = Instantiate(Me, transform.position, Quaternion.identity);
            //cloneLaser.transform.localScale = new Vector3(0.02f,0.02f,3);
            //cloneLaser.transform.Rotate(x2,y2,z2);

            //cloneLaser.transform.Rotate(y2,z2,x2);

            //GameObject cloneObject = Instantiate(cloneLaser,Quaternion.identity);
            //cloneObject.transform.Translate(0,0,-1);

            Debug.Log ("dekitemasu");
            mesh.material.color = mesh.material.color + new Color32(0,0,0,255);

            if (HowManyTimes2 == 3)
            {
                carMove.ItemNumber = 0;
                HowManyTimes2 = 0;
            }
            //transform.position = new Vector3 ( px+=10.925f , py-=28.665f , pz+=108.5f );
            //transform.Rotate(x2 + 90,z2 - 1,-y2);
            //transform.position = tmp;
            //this.gameObject.SetActive(true);
            //レーザーを動かすスクリプト
        }
    }
}
