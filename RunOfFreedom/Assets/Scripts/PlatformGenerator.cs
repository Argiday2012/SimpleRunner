using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    [SerializeField] private GameObject platform;
    [SerializeField] private Transform generatorPoint;
    [SerializeField] private float distBetweenPlatform;

    [SerializeField] private float minDistBetweenPlatform;
    [SerializeField] private float maxDistBetweenPlatform;

    //public PlatformManager PlatformM;

    public GameObject[] Platforms;
    int platformSelector;
    float[] platformsWidth;


    //private float platformWidth;

    private void Start()
    {
        //platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
        platformsWidth = new float[Platforms.Length];
        for(int i = 0; i < Platforms.Length; i++)
        {
            platformsWidth[i] = Platforms[i].GetComponent<BoxCollider2D>().size.x;
        }
    }

    private void Update()
    {
        if(transform.position.x < generatorPoint.position.x)
        {
            distBetweenPlatform = Random.Range(minDistBetweenPlatform, maxDistBetweenPlatform);
            platformSelector = Random.Range(0, Platforms.Length);

            transform.position = new Vector3(transform.position.x + platformsWidth[platformSelector] + distBetweenPlatform, transform.position.y, transform.position.z);
            Instantiate(/*platform,*/ Platforms[platformSelector], transform.position, transform.rotation);
            //GameObject newPlatform = PlatformM.GetPlatform();

            //newPlatform.transform.position = transform.position;
            //newPlatform.transform.rotation = transform.rotation;
            //newPlatform.SetActive(true);

        }
    }

}
