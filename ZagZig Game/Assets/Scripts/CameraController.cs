using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;

    private Vector3 offset;
    [SerializeField] Vector3 newPos;

    [SerializeField] [Range(0,3)] private float lerpValue;
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    void LateUpdate()
    {
        SetCameraFollow();
    }

    private void SetCameraFollow(){
        newPos = Vector3.Lerp(transform.position,ballTransform.position + offset, lerpValue* Time.deltaTime);
        transform.position = newPos;
    }
}
