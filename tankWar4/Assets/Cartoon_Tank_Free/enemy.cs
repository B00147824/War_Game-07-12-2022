using System. Collections; 
using System. Collections.Generic; 
using UnityEngine;

public class enemy : MonoBehaviour

{

public Transform shot;
public hero heroScript;

void Start()
{
   StartCoroutine(delayShot());

}
void Update( )	


{ //look of he tank 
    transform.LookAt (hero. currentPos) ;
    //move in the derection you are faceign 

	GetComponent<Rigidbody>().velocity = transform. forward * 1.7f;
    //heroScript = hero.Find()
}



IEnumerator delayShot ()
{
  // delay shot 4 second
yield return new WaitForSeconds (4);
//instatiate the shot on the tank
Instantiate(shot, new Vector3(transform.position.x,1.57f, transform.position.z), transform.rotation);
// keep shoting loop
StartCoroutine(delayShot());
}


}