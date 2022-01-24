using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // initialize speed for vehicle
    public float vehicleSpeed = 5.0f;// f behind 5.0 is for float, if not it will be as douhble.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // here you enter code to move vehicle forward
        //transform.Translate(0, 0, 1); // moves vehicle very fast forward
        //transform.Translate(Vector3.forward); // the same like transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
    }
}
