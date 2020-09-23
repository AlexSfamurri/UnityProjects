using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left")) {
            this.transform.localRotation *= Quaternion.Euler ( new Vector3(0, 1, 0));
        }
        if(Input.GetKey("right")) {
            this.transform.localRotation *= Quaternion.Euler ( new Vector3(0, -1, 0));
        }
        if(Input.GetKey("space")) {
            this.transform.localRotation = Quaternion.identity;
        }
    }
}
