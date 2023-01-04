using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectPooling
{
    public static void Init<T>(T prefab, int size, List<T> list, Transform parent) where T : Component
    {
        for (int i = 0; i < size; i++)
        {
            T obj = GameObject.Instantiate(prefab, parent);
            obj.gameObject.SetActive(false);
            list.Add(obj);
        }
    }

    public static T GetObjectInPool<T>(T prefab, bool expandable, List<T> list, Transform parent) where T : Component
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (!list[i].gameObject.activeInHierarchy)
            {
                int random =  Random.Range(0, list.Count);
                return list[random];
                
            }
        }
        if (expandable)
        {
            T obj = GameObject.Instantiate(prefab, parent);
            obj.gameObject.SetActive(false);
            list.Add(obj);
        }
        return null;
    }
    public static void Activated<T>(T prefab, bool expandable, List<T> list, Transform parent, Vector3 origin) where T : Component
    {
        T obj = GetObjectInPool<T>(prefab, expandable, list, parent);
        if (obj != null)
        {
         
            obj.transform.position = origin;
            obj.gameObject.SetActive(true);
        }
    }
}
