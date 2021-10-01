﻿using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;

    private void Start()
    {
        startEvent.Invoke();
    }
}
