using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform Player {  get; set; }
    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        this.transform.position = new Vector3(Player.position.x, this.transform.position.y, Player.transform.position.z);
    }
}
