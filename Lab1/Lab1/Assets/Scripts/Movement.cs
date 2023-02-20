using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement:MonoBehaviour
{
    public float acceleration = 0.1f;
    public float maxSpeed = 0.1f;
    private float speedX;
    private float speedZ;

    // Start is called before the first frame update
    void Start()
    {
        speedX = 0f;
        speedZ = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        speedX += Input.GetAxis("Horizontal") * Time.deltaTime * acceleration;
        speedZ += Input.GetAxis("Vertical") * Time.deltaTime * acceleration;

        if(speedX > maxSpeed)
            speedX = maxSpeed;
        if(speedZ > maxSpeed)
            speedZ = maxSpeed;
        if(speedX < -1*maxSpeed)
            speedX = -1*maxSpeed;
        if(speedZ < -1*maxSpeed)
            speedZ = -1*maxSpeed;  
    
        transform.Translate(new Vector3(speedX, 0, speedZ));
    }
}
