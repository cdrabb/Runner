using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public float speed = .5f;
    public float offset;
    public Sprite[] backgroundSprites;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    //The background object is shifted behind the sibling and the sprite is changed
    public void Reposition()
    {
        BackgroundController controller = FindObjectOfType<BackgroundController>();
        this.transform.position += Vector3.right * offset * 2;
        GetComponent<SpriteRenderer>().sprite = backgroundSprites[Random.Range(0, backgroundSprites.Length)];
    }
}
