using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnContolelr : MonoBehaviour
{
    public GameObject lastGroundObj;
    [SerializeField] private GameObject groundPrefab;

    private GameObject newGroundObject;

    private int groundDir;
    void Start()
    {
        GenerateRandomNewGrounds();   
    }

    public void GenerateRandomNewGrounds(){
        for(int i = 0; i<100;i++){
            CreateGround();
        }
    }

    private void CreateGround(){

        groundDir = Random.Range(0,2);

        if(groundDir == 0){
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObj.transform.position.x - 1f, lastGroundObj.transform.position.y,lastGroundObj.transform.position.z), Quaternion.identity);
            lastGroundObj = newGroundObject;
        }
        else{
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObj.transform.position.x, lastGroundObj.transform.position.y,lastGroundObj.transform.position.z +1f), Quaternion.identity);
            lastGroundObj = newGroundObject;


        }
    }
}
