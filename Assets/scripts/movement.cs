using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEditor.Callbacks;
using System;

public class movement : MonoBehaviour
{
    
    public float senx=900;
    public float seny=900;
    float xrotation;
    float yrotation;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxisRaw("Mouse X") *Time.deltaTime*senx;
        float mousey = Input.GetAxisRaw("Mouse Y") *Time.deltaTime*seny;
        yrotation += mousex;
        xrotation -=mousey;
        xrotation=Mathf.Clamp(xrotation,-90f,90f);
        //rotate cam 
        transform.rotation=Quaternion.Euler(xrotation,yrotation,0);


    }


}
