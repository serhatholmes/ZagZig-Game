using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawnContolelr groundSpawnContolelr;
    private Rigidbody rb;
    [SerializeField] private float endYValue;
    private int groundDir;
    void Start()
    {
        groundSpawnContolelr = FindObjectOfType<GroundSpawnContolelr>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundPos();
    }

    private void CheckGroundPos(){
        if(transform.position.y <= endYValue){
            SetRigidbodyValue();

            SetGroundNewPos();
        }
    }

    private void SetGroundNewPos(){
        groundDir = Random.Range(0,2);

        if(groundDir == 0){
            transform.position = new Vector3(groundSpawnContolelr.lastGroundObj.transform.position.x-1f,groundSpawnContolelr.lastGroundObj.transform.position.y,groundSpawnContolelr.lastGroundObj.transform.position.z);
        }
        else{
            transform.position = new Vector3(groundSpawnContolelr.lastGroundObj.transform.position.x,groundSpawnContolelr.lastGroundObj.transform.position.y,groundSpawnContolelr.lastGroundObj.transform.position.z+1f);
        }

        groundSpawnContolelr.lastGroundObj = gameObject;
    }

    private void SetRigidbodyValue(){

        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
