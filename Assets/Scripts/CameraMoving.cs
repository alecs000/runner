using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    private void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z-3);
    }
}
