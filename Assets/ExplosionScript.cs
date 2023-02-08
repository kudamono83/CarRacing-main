using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplosionScript : MonoBehaviour
{
    public GameObject car;
    public GameObject bomb;
    Exploder exploder;
    CarMove carMove;
    int BombNumber;
    GameObject cloneObject;
    Rigidbody rb;

    public float Value;
    public Slider Gauge;
    private bool GaugeStop;

    public Material BlackColor;
    public Material ClearColor;

    // Start is called before the first frame update
    void Start()
    {
        exploder = bomb.GetComponent<Exploder>();
        carMove = car.GetComponent<CarMove>();

        transform.position = new Vector3(0,0,0);

        Value = 0;
        Gauge.gameObject.SetActive (false);
        GaugeStop = true;
    }

    // Update is called once per frame
    void Update()
    {
        Transform BomTransform = bomb.transform;
        Vector3 worldAngle = BomTransform.eulerAngles;
        Vector3 pos = BomTransform.position;

        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (GaugeStop == true)
            {
                Gauge.gameObject.SetActive (true);
                GaugeStop = false;

                bomb.GetComponent<Renderer>().material.color = BlackColor.color;
            }
            else
            {
                GaugeStop = true;

                cloneObject = Instantiate(bomb, pos, Quaternion.identity);
                cloneObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                cloneObject.transform.eulerAngles = worldAngle;

                cloneObject.AddComponent<BombMove>();
                cloneObject.AddComponent<SphereCollider>();
                rb = cloneObject.GetComponent<Rigidbody>();
                rb.useGravity = true;
                rb.isKinematic = false;
                rb.AddForce(cloneObject.transform.up * (Value * 10 + 250));

                bomb.GetComponent<Renderer>().material.color = ClearColor.color;
                cloneObject.GetComponent<Renderer>().material.color = BlackColor.color;

                StartCoroutine(DelayCoroutine2());
            }
        }
        //BombNumber = carMove.ItemNumber;

        //if ((Input.GetKeyDown(KeyCode.I)) && (BombNumber == 6))
        //{
            //transform.position = new Vector3(15.20303f,1.452f,97.06855f);
        //}
        //else
        //{
            //sphere.SetActive (false);
        //}

        Gauge.value = Value;

        if(Value > 100)
        {
            Value = 1;
        }

        if(GaugeStop == false)
        {
            Value += Time.deltaTime * 100;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plane")
        {
            exploder.enabled = true;
            //yield return new WaitForSeconds(0.5f);
            StartCoroutine(DelayCoroutine());
            //sphere.SetActive (false);
        }
    }

    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        bomb.SetActive (false);
    }

    private IEnumerator DelayCoroutine2()
    {
        yield return new WaitForSeconds(2.0f);
        if (GaugeStop == true)
        {
            Gauge.gameObject.SetActive (false);
        }
    }
}
