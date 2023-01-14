using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

    [SerializeField] private GameObject platform;
    [SerializeField] private int platformAmount;

    List<GameObject> platforms;

    private void Start()
    {
        platforms = new List<GameObject>();

        for(int i = 0; i < platformAmount; i++)
        {
            GameObject obj = Instantiate(platform);
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
        GameObject obj = Instantiate(platform);
        obj.SetActive(false);
        platforms.Add(obj);
        return obj;
    }
}
