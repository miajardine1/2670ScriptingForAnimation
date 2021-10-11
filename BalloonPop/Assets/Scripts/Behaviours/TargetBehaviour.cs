using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Random = System.Random;
using Vector3 = UnityEngine.Vector3;

public class TargetBehaviour : MonoBehaviour
{
    private Rigidbody target;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;

    private void Start()
    {
        target = GetComponent<Rigidbody>();
        target.AddForce(RandomForce(), ForceMode.Impulse);
        target.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(), ForceMode.Impulse)));
        transform.position = new Vector3(RandomSpawnPos());
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
