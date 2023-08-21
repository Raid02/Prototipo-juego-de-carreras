using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(-5,20),SerializeField]
    private float speed = 20f;
    [Range(-5,100),SerializeField]
    public float turnspeed = 100f;
    private float HorizontalInput,VerticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      HorizontalInput= Input.GetAxis("Horizontal");
      Debug.Log("MOVIMIENTO HORIZONTAL "+HorizontalInput);
      VerticalInput= Input.GetAxis("Vertical");
      Debug.Log("MOVIMIENTO VERTICAL "+VerticalInput);
      this.transform.Translate(speed*Time.deltaTime*Vector3.forward*VerticalInput);
      if(VerticalInput>0){
      this.transform.Rotate(turnspeed*Time.deltaTime*Vector3.up*HorizontalInput);
      }else if(VerticalInput<0){    
      this.transform.Rotate(turnspeed*Time.deltaTime*Vector3.up*HorizontalInput*-1);
      }else{
        this.transform.Rotate(turnspeed*Time.deltaTime*Vector3.up*HorizontalInput*0);
      }
    }
}
