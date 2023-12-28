using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    private float speed=5.0f;
    public float jumpforce=5.0f;
    private float horizontalinput;
    private float forwardinput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //get player input
        horizontalinput=Input.GetAxis("Horizontal");
        forwardinput=Input.GetAxis("Vertical");
        //move the player forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardinput);
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalinput);

}
}