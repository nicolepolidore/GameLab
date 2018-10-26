using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {


    public GameObject Bullet;
    Rigidbody rb;


    public float bulletSpeed;


    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {

        Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, 0),transform.rotation);
    } 
  



}


