using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "block")
        {
            Debug.Log("Namaste World");
            Destroy(col.gameObject);
        }
    }



}
