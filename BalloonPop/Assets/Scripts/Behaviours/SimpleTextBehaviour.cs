using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SimpleTextBehaviour : MonoBehaviour
{
    private Text Label;

    private void Awake()
    {
        Label = GetComponent<Text>();
    }

    public void UpdateTextValue(IntData obj)
    {
        Label.text = obj.value.ToString();
    }
    
    //rewritten from https://github.com/anthonyromrell/2670ScriptingFall2021/tree/main/2670/Assets/Scripts// 
}
