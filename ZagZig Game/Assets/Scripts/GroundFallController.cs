using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    public IEnumerator SetRigidbodyValue(){

        yield return new WaitForSeconds(0.5f);
        rb.isKinematic = false;
        rb.useGravity = true;

    }
}
