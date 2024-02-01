using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] int maxHP = 100; //max available HP
    [SerializeField] int currentHP = 0; //current HP
    [SerializeField] int bumpCounter = 0; //to count # of collisions or bumps

    void Start(){
        // Initial hp set to max:
        currentHP = maxHP;
    
    }
   private void OnCollisionEnter(Collision other) {
    
    if(!other.gameObject.CompareTag("ObjectHit") ){
        if(!other.gameObject.CompareTag("Plane"))
            {
                 bumpCounter++;
                currentHP--;
                Debug.Log("Collision! HP is now: "+ currentHP +", # of collisions: "+bumpCounter);
            }       
    }
    

   }
}
