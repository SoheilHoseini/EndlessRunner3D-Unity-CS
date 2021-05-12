using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    private Transform lookAt; //we want to connect the camera to the transform component if the player
    private Vector3 startOffSet;
    private Vector3 moveVector;

    private float transition = 0.0f;
    private float animationDuration = 2.0f;//it takes 2 sec to complete the animation of moving the camera
    private Vector3 animationCameraOffSet = new Vector3(0 , 5 , 5);//at the beggining, the camera will start from a height and slowly comes down

    // Start is called before the first frame update
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffSet = transform.position - lookAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = lookAt.position + startOffSet;
        //X
        moveVector.x = 0;//the camera stays at the center of the road
        //Y
        moveVector.y = Mathf.Clamp(moveVector.y, 3, 5);//restrict the vertical movement of the camera

        if(transition > 1.0f)
        {
            transform.position = moveVector;// the position of the camera is the position of the player
        }
        else
        {
            //Animation at the start of the game
            transform.position = Vector3.Lerp(moveVector + animationCameraOffSet, moveVector, transition);
            transition += Time.deltaTime * 1 / animationDuration;//control the speed of the camera when it comes down
            transform.LookAt(lookAt.position + Vector3.up);//to look at the player when it is coming down
        }

        
    }
}
