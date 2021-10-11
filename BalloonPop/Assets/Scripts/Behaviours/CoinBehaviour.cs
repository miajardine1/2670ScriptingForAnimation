using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public IntData intDateObj;

    private void OnTriggerEnter(Collider other)
    {
        intDataObj.value++;
    }
//rewritten from https://github.com/anthonyromrell/2670ScriptingFall2021/tree/main/2670/Assets/Scripts//
}
