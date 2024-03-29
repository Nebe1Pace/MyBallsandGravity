﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_II : MonoBehaviour
{
    Rigidbody Rbody1, Rbody2;
    public Rigidbody DrugoiRbody1, DrugoiRbody2;
    public Vector3 r1, r2; //тел
    public Vector3 R1, R2; //силы
    public Vector3 V1, V2; 
    float g = 6.67408e-2F;
    public float m, M;
    void Start()
    {
        Rbody1 = GetComponent<Rigidbody>();
        Rbody1.position = r1;
        Rbody1.velocity = V1;

        Rbody2 = GetComponent<Rigidbody>();
        Rbody2.position = r2;
        Rbody2.velocity = V2;
    }
    void Update()
    {
        r1 = Rbody1.position - DrugoiRbody1.position;
        R1 = Rbody1.position;
        float l1 = -g * m / Mathf.Pow(r1.magnitude, 2);
        float L1 = -g * M / Mathf.Pow(R1.magnitude, 2);
        Rbody1.AddForce(l1 * r1 + L1 * R1); //Добавляет крутящий момент к физическому телу

        r2 = Rbody2.position - DrugoiRbody2.position;
        R2 = Rbody2.position;
        float l2 = -g * m / Mathf.Pow(r2.magnitude, 2);
        float L2 = -g * M / Mathf.Pow(R2.magnitude, 2);
        Rbody2.AddForce(l2 * r2 + L2 * R2); //Добавляет крутящий момент к физическому телу
    }
}