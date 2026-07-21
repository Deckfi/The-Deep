using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position = cameraPosition.position;
        Debug.Log($"Cam position:{transform.position}, Target position:{cameraPosition.position}");
    }
}
