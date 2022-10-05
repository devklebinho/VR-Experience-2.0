using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 2f;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        GameObject createdBullet = Instantiate(bullet);
        createdBullet.transform.position = spawnPoint.position;
        Rigidbody bullet_rig =  createdBullet.GetComponent<Rigidbody>();
        Camera cam = GetComponentInChildren<Camera>();

        bullet_rig.velocity = cam.transform.rotation * Vector3.forward * speed;
    }
}
