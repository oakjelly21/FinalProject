 using UnityEngine;
 using System.Collections;
 
 public class Player_Health : MonoBehaviour {
 
     public static float curHealth = 100f;
     public static float maxHealth = 100f;
     public static float decHealth = 6f;
     public static float regHealth = 0.1f;
 
     void Start(){
         curHealth = 98f;
         }
 
     void Update(){
         if (curHealth < maxHealth) {
             curHealth += regHealth * Time.deltaTime;
             Debug.Log(curHealth);
         }
     }

    void OnCollisionEnter(Collision other)
    {
         if (other.gameObject.tag == "Enemy") {
             curHealth -= decHealth * Time.deltaTime;
             Debug.Log(curHealth);
         }
     }
}