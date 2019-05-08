
using UnityEngine;
 
public class MovingStuff : MonoBehaviour
{
    float xspeep = 0f;
     float power = 1.001f;
     float friction = 0.95f;
     bool right = false;
     bool left = false;
     
     public float fuel = 2;
     
     
     // Use this for initialization
     void FixedUpdate () {
         
         
         if(right){
             xspeep += power;
             fuel -= power;
         }
         if(left){
             xspeep -= power;
             fuel -= power;
         }
         
         
     }
     
     // Update is called once per frame
     void Update () {
         
         if(Input.GetKeyDown("d")){
             left = true;
			//  this.Object019.transform.Rotate(Vector3.up * mSpeed * Time.deltaTime);
			//  this.Object020.transform.Rotate(Vector3.up * mSpeed * Time.deltaTime);
			//  this.Object021.transform.Rotate(Vector3.up * mSpeed * Time.deltaTime);
			//  this.Object022.transform.Rotate(Vector3.up * mSpeed * Time.deltaTime);
         }
         if(Input.GetKeyUp("d")){
             left = false;
         }
         if(Input.GetKeyDown("a")){
             right = true;
         }
         if(Input.GetKeyUp("a")){
             right = false;
         }
         
         if(fuel < 0){
             
             xspeep = 0;
             
         }
         
         xspeep *= friction;
         transform.Translate(Vector3.forward * -xspeep);
     
     }

}