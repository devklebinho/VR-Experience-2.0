using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject createdBullet = Instantiate(bullet);
            createdBullet.transform.position = transform.position;
            Rigidbody bullet_rig = createdBullet.GetComponent<Rigidbody>();
            Camera cam = GetComponentInChildren<Camera>();

            bullet_rig.velocity = cam.transform.rotation * Vector3.forward * speed;
        }
    }
}
