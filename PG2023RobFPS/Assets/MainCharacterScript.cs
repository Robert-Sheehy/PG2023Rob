using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterScript : MonoBehaviour
{
    FPSCameraScript camera;
    private float speed;
    private float turnSpeed;
    const float WALKING_SPEED = 3, RUNNING_SPEED = 8, CROUCH_SPEED = 1;
    const float WALKING_TURN = 90, RUNNING_TURN = 45, CROUCH_TURN = 90;






    // Start is called before the first frame update

    void Start()
    {
        speed = WALKING_SPEED;
        turnSpeed = WALKING_TURN;
        camera = FindObjectOfType<FPSCameraScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.position,Vector3.up, turnSpeed * Time.deltaTime);
        }




        camera.UpdatePosition(this, Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
