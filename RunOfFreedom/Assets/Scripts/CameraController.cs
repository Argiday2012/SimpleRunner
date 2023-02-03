using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] private GameObject hero;

    //public PlayerController Player;

    //private Vector3 lastPosition;
    //private float distToMove;

    private void Start()
    {
        //Player = FindObjectOfType<PlayerController>();

        //lastPosition = Player.transform.position;
    }

    private void Update()
    {

        transform.position = new Vector3(hero.transform.position.x + 5f, hero.transform.position.y + 1f, -10f);
        //distToMove = Player.transform.position.x - lastPosition.x;

        //transform.position = new Vector3(transform.position.x + distToMove, transform.position.y, transform.position.z);
        //lastPosition = Player.transform.position;
    }

}
