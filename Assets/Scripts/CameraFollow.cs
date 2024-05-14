using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            cam.transform.position = new Vector3(target.position.x, target.position.y, cam.transform.position.z);
        }
    }
}
