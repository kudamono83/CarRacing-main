using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BombMove : MonoBehaviour
{
    public float power;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Plane")
        {
            StartCoroutine(DelayCoroutine(1, () =>
            {
                Vector3 explosionPos = transform.position;

                var ex = GameObject.Find("BigExplosion");
                ex.transform.position = explosionPos;
                ex.GetComponent<ParticleSystem>().Play();

                Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
                foreach (Collider hit in colliders)
                {
                    Rigidbody rb = hit.GetComponent<Rigidbody>();

                    if (rb != null)
                        rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
                }
            }));
        }
    }

    private IEnumerator DelayCoroutine(float seconds, Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }
}
