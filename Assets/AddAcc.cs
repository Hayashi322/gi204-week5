using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAcc : MonoBehaviour
{
    public float force, mass, acceleration;

    void CalculateForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        force = mass * acceleration;
        GetComponent<Rigidbody>().AddForce(force, force, 0);

    }//CalculateForce

    public void Botton250()
    {
        acceleration = 250;
        CalculateForce();
    }

    public void Botton300()
    {
        acceleration = 300;
        CalculateForce();
    }
    public void Botton350()
    {
        acceleration = 350;
        CalculateForce();
    }
}//AddAcc
