using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent startEvent, respondEvent, respondLateEvent,runInAnimatorEvent;
    public float holdTime = 0.1f;
    private WaitForSeconds waitObj;
    public UnityAction raiseNoArgs;


    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnEnable()
    { 
        waitObj = new WaitForSeconds(holdTime);
        Action.raiseNoArgs += Respond;
    }

    private void Respond()
    {
    respondEvent.Invoke();
    StartCoroutine(RespondLate());
    }

    private IEnumerator RespondLate()
    {
        yield return waitObj;
        respondLateEvent.Invoke();
    }

    private void OnDestroy()
    {
        Action.raiseNoArgs = null;
    }
}

//https://github.com/anthonyromrell/2670ScriptingFall2021

