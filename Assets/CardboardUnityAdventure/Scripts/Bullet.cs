using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Bullet : MonoBehaviour
{
    Rigidbody bulletRig;
    public float speed = 2f;
    void Start()
    {
        bulletRig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        bulletRig.AddForce(transform.forward * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("EnemyLv2"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Bateu no enemy");
        }
    }
}
