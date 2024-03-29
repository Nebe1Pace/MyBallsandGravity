using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody Rbody;
    public Rigidbody DrugoiRbody;
    public Vector3 r;
    public Vector3 R;
    public Vector3 V;
    float g = 6.67408e-2F;
    public float m, M;
    void Start()
    {
        Rbody = GetComponent<Rigidbody>();
        Rbody.position = r;
        Rbody.velocity = V;
    }
    void Update()
    {
        r = Rbody.position - DrugoiRbody.position;
        R = Rbody.position;
        float l = -g * m / Mathf.Pow(r.magnitude, 2);
        float L = -g * M / Mathf.Pow(R.magnitude, 2);
        Rbody.AddForce(l * r + L * R);
    }
}