using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

    [SerializeField] private GameObject pointDestroy;

    private void Start()
    {
        pointDestroy = GameObject.Find("PointPlatformDestroy");
    }

    private void Update()
    {
        if(transform.position.x < pointDestroy.transform.position.x)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
