using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

    [SerializeField] public GameObject Platform;
    [SerializeField] private int platformAmount;

    List<GameObject> platforms;

    private void Start()
    {
        platforms = new List<GameObject>();

        for(int i = 0; i < platformAmount; i++)
        {
            GameObject obj = Instantiate(Platform);
            obj.SetActive(false);
            platforms.Add(obj);
        }
    }

    public GameObject GetPlatform()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            if(!platforms[i].activeInHierarchy)
            {
                return platforms[i];
            }
        }
        GameObject obj = Instantiate(Platform);
        obj.SetActive(false);
        platforms.Add(obj);
        return obj;
    }
}
