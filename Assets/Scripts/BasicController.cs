﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    void Update()
    {
        Debug.Log( "Horizontal input = " + Input.GetAxis("Horizontal") );
    }
}
