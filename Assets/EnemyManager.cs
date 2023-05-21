using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Sign1;
    public GameObject Sign2;
    public GameObject Sign3;
    public GameObject Sign4;
    public GameObject Sign5;
    public GameObject Sign6;
    public GameObject Sign7;
    public GameObject Sign8;
    public GameObject Sign9;
    public GameObject Sign10;
    public GameObject Sign11;
    public GameObject Enemy;
    GameObject cloneObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Transform SignTransform = RndSign.transform;
            //Vector3 pos = SignTransform.position;
            //pos.y += 5.0f;
            //Vector3 worldAngle = SignTransform.eulerAngles;
            //cloneObject = Instantiate(Enemy, pos, Quaternion.identity);
            //cloneObject.transform.eulerAngles = worldAngle;

            Vector3 pos1 = Sign1.transform.position;
            //pos1.y += 5.0f;
            float x1 = pos1.x;
            float y1 = pos1.y + 5.0f;
            float z1 = pos1.z;
            Debug.Log (pos1);
            Instantiate(Enemy, new Vector3(x1,y1,z1), Quaternion.identity);

            Vector3 pos2 = Sign2.transform.position;
            pos2.y += 5.0f;
            Debug.Log (pos2);
            Instantiate(Enemy, pos2, Quaternion.identity);

            Vector3 pos3 = Sign3.transform.position;
            pos3.y += 5.0f;
            Debug.Log (pos3);
            Instantiate(Enemy, pos3, Quaternion.identity);

            Vector3 pos4 = Sign4.transform.position;
            pos4.y += 5.0f;
            cloneObject = Instantiate(Enemy, pos4, Quaternion.identity);

            Vector3 pos5 = Sign5.transform.position;
            pos5.y += 5.0f;
            cloneObject = Instantiate(Enemy, pos5, Quaternion.identity);

            Vector3 pos6 = Sign6.transform.position;
            pos6.y += 5.0f;
            cloneObject = Instantiate(Enemy, pos6, Quaternion.identity);

            Vector3 pos7 = Sign7.transform.position;
            pos7.y += 5.0f;
            cloneObject = Instantiate(Enemy, pos7, Quaternion.identity);

            Vector3 pos8 = Sign8.transform.position;
            pos8.y += 5.0f;
            cloneObject = Instantiate(Enemy, pos8, Quaternion.identity);

            Vector3 pos9 = Sign9.transform.position;
            pos9.y += 5.0f;
            cloneObject = Instantiate(Enemy, pos9, Quaternion.identity);

            Vector3 pos10 = Sign10.transform.position;
            pos10.y += 5.0f;
            cloneObject = Instantiate(Enemy, pos10, Quaternion.identity);

            Vector3 pos11 = Sign11.transform.position;
            pos11.y += 5.0f;
            cloneObject = Instantiate(Enemy, pos11, Quaternion.identity);
        }
    }
}
