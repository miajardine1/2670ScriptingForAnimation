using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void AddToValue(float num)
    {
        value += num;
    }

    public void ResetValue(float num)
    {
        value = num;
    }
    //Anthony Romrell https://github.com/anthonyromrell/2670ScriptingFall2021/tree/main/2670part2/Assets
}
