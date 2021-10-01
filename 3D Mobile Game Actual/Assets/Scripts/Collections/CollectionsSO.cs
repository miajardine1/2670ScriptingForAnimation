using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectionsSO : ScriptableObject
{
    public List<CollectableSO> collection;

    public void Collect(CollectableSO obj)
    {
        collection.Add(obj);
        obj.collected = true;
    }
}
