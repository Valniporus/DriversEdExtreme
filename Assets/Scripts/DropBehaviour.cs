using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBehaviour : MonoBehaviour
{
   
   MeshRenderer mRenderer;
   Rigidbody rigid_body;
   // Start is called before the first frame update
    void Start()
    {
        // We cache the component references
        mRenderer = GetComponent<MeshRenderer>();
        rigid_body =GetComponent<Rigidbody>(); 

        mRenderer.enabled = false;
        rigid_body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 5){
            mRenderer.enabled = true;
            rigid_body.useGravity = true;
            
        }
    }
}
