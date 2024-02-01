using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class ObjectHitWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        
        // It must only turn red if the player hits it.
        if(other.gameObject.CompareTag("Player"))
        {

            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "ObjectHit";
            StartCoroutine(ChangeColorAfterDelay(2));
        }
        
        
        
    }

    private IEnumerator ChangeColorAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Change color to black
        string hexColor = "#000000";
        Color colorDefault = ColorUtility.TryParseHtmlString(hexColor, out Color newColor) ? newColor : Color.black;
        GetComponent<MeshRenderer>().material.color = colorDefault;
    }

}
