using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float movementspeed;
    [SerializeField] private float horspeed;
    private float hor;

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor*horspeed*Time.deltaTime,0,movementspeed*Time.deltaTime));
    }
}
