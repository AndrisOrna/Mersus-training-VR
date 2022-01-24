using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVehicle : MonoBehaviour
{
    public GameObject playerToFollow;

    // offset should be private, choosed bublic to see how it looks camera from different angles.
    // location of the camera for player
    public Vector3 offset = new Vector3(0, 5, -7);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // LateUpdate is for smoothing both vehicle and camera movements
    void LateUpdate()
    {
        // Offset the camera behind the playewr by adding to the players position
        transform.position = playerToFollow.transform.position + offset;
    }
}
