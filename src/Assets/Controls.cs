using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) {
            transform.position = transform.position + new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position = transform.position + new Vector3(1, 0, 0);
        }
    }
}
