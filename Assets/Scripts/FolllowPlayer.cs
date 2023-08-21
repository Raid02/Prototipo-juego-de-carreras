using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolllowPlayer : MonoBehaviour
{
    public GameObject objeto;
    private Vector3 offset = new Vector3(0,5,-6);
    /*private float HorizontalInput,VerticalInput;
    public float turnspeed = 100f;
    */private void Update()
    {
        /*HorizontalInput= Input.GetAxis("Horizontal");
        VerticalInput= Input.GetAxis("Vertical");*/
        this.transform.position=objeto.transform.position+offset;
        Debug.Log("Posicion camara "+transform.position);
      /*if(VerticalInput>0){
      this.transform.Rotate(turnspeed*Time.deltaTime*Vector3.up*HorizontalInput);
      }else if(VerticalInput<0){    
      this.transform.Rotate(turnspeed*Time.deltaTime*Vector3.up*HorizontalInput*-1);
      }else{
      this.transform.Rotate(turnspeed*Time.deltaTime*Vector3.up*HorizontalInput*0);
      }*/
    }

}