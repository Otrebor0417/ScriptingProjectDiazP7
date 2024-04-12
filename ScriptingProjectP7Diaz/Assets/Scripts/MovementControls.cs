using UnityEngine;
using System.Collections;
public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
 
 
    
    void Update()
    {
        Movement();
    }


    void Movement ()
    {
        float fowardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * fowardMovement);
        transform.Rotate(Vector3.forward * turnMovement);
    }
}
