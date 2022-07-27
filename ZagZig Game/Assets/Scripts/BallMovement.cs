using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private BallDataTrsn ballDataTrsn;

    [SerializeField] private float ballMoveSpeed;

    private void Update(){
        SetBallMovement();
    }

    private void SetBallMovement(){
        transform.position += ballDataTrsn.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
