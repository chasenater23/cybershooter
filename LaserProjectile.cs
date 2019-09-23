﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserProjectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);    
    }

    void Destroy()
    {
        //play effect
        //instanitate(effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
