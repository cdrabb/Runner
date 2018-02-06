using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {

    //This will shred all gameobjects other than backgrounds
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Background background = collision.gameObject.GetComponent<Background>();
        if (!background)
        {
            Destroy(collision.gameObject);
        }
        else
        {
            background.Reposition();
        }
    }
}
