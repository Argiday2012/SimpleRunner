using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public PlayerController Player;

    private Vector3 lastPosition;
    private float distToMove;

    private void Start()
    {
        Player = FindObjectOfType<PlayerController>();

        lastPosition = Player.transform.position;
    }

    private void Update()
    {
        distToMove = Player.transform.position.x - lastPosition.x;

        transform.position = new Vector3(transform.position.x + distToMove, transform.position.y, transform.position.z);
        lastPosition = Player.transform.position;
    }

}
