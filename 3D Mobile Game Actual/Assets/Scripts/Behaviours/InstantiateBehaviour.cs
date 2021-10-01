using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBehaviour : MonoBehaviour
{
    public void OnInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
