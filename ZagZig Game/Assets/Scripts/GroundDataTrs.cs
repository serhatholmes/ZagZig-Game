using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTrs : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;


    public void SetGroundRigidbodyValue(){
        StartCoroutine(groundFallController.SetRigidbodyValue());
    }
}
