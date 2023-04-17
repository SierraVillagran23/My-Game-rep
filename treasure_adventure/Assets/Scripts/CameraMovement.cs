using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 10.0f;
    private Vector3 offset = new Vector3(0, 6, -3);
    private Vector3 rotationAngle = new Vector3(-6, 3, -5);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // gets the camera to follow the player
        transform.position = player.transform.position + offset;
        Rotation();
        transform.LookAt(player.transform.position);

        
    }
    void Rotation()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2f, Vector3.up) * rotationAngle;
    }
}
