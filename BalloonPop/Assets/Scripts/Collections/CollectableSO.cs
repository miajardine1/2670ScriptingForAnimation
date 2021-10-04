using UnityEngine;

public class CollectableSO : ScriptableObject
{
    public bool collected;
    [SerializeField] public Sprite art;
    public Color artColorTint;
}
