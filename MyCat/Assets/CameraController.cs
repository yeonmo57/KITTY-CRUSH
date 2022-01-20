using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //플레이어의 위치로 카메라 이동
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
            playerPos.x, playerPos.y, transform.position.z);
    }
}
