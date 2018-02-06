using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

    public Background[] backgrounds;

    // Use this for initialization
    void Start()
    {
        
        SpriteRenderer renderer = backgrounds[1].GetComponent<SpriteRenderer>();
        backgrounds[0].offset = renderer.bounds.size.x;

        renderer = backgrounds[0].GetComponent<SpriteRenderer>();
        backgrounds[1].offset = renderer.bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
