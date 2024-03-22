using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // this things position (camera) shoud be the same as the car's position
    // change Update() to LateUpdate()
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
