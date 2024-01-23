using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0F;
    bool canJump;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) {
            transform.position = transform.position + new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position = transform.position + new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W) && canJump) {
            Debug.Log("pressing W");
            transform.position = transform.position + new Vector3(0, 1F, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Vector3 normal = other.GetContact(0).normal;
            if(normal == Vector3.up){
                canJump = true;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            canJump = false;
        }
    }
    
}
