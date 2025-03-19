using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 2;
    public float horizontalSpeed = 3;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
        
    // Update is called once per frame
    void Update()
    {
        // Forward movement automatic
        transform.Translate(Vector3.forward * (Time.deltaTime * playerSpeed), Space.World);
        
        // Left input (A) || (LeftArrow) move left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * (Time.deltaTime * horizontalSpeed));
            }
        }
        // Right input (D) || (RightArrow) move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.left * (Time.deltaTime * horizontalSpeed * -1));
            }
        }
    }
}
