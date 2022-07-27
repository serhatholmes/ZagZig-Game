using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] colors;

    private int colorIndex = 0;

    [SerializeField] private float lerpValue;

    [SerializeField] private float time;

    private float currentTime;

    private void Update() {
        
        SetColorChangeTime();
        SetGroundColorChange();
    }

    private void SetColorChangeTime(){

        if(currentTime <=0){

            CheckColorIndex();
            currentTime = time;
        }
        else{
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndex(){

        colorIndex ++;

        if(colorIndex >= colors.Length ){

            colorIndex = 0;

        }
    }

    private void SetGroundColorChange(){
        groundMaterial.color = Color.Lerp(groundMaterial.color,colors[colorIndex], lerpValue * Time.deltaTime);
    }

    private void OnDestroy(){
        groundMaterial.color = colors[1];
    }
}
