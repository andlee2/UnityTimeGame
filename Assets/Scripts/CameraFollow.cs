
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 0, -1);
    
    public bool followCamera = true;
    
  

    

    void LateUpdate ()
    {

        if (followCamera) {
            Vector3 desiredPosition = target.position + offset;
            transform.position = desiredPosition;
        } 

    }
}
