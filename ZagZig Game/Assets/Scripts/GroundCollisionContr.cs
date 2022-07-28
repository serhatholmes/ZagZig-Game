using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionContr : MonoBehaviour
{
    [SerializeField] private GroundDataTrs groundDataTrs;
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("Ball")){
            groundDataTrs.SetGroundRigidbodyValue();
        }
    }
}
