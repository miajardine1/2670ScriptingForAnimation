using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent respondEvent;
    
    private void Start()
    {
    gameActionObj.raise += Respond;
    }
    
    private void Respond()
    {
    respondEvent.Invoke();
    }
}

//https://github.com/anthonyromrell/2670ScriptingFall2021

