﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float BulletSpeed = 2f;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        ShootBullet();
    }

    void ShootBullet()
    {
        var bullet = Instantiate(Bullet);
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;

        var bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = transform.right * BulletSpeed;
    }
}
