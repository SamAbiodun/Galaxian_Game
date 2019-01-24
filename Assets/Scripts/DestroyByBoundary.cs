﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.tag == "EnemyProjectile" || other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }


    //downlod PaintNet
}
