using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int health = 100;
    public Animator animator;
    public float jumpHeight = 10f;
    public float yPos;
    public bool airborne = false;
    public bool jump = false;
    public bool roll = false;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //If in run animation, we are inactive
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("PlayerRun"))
        {
            jump = false;
            roll = false;
            airborne = false;
        }
		
        //Jump preperation frame
        if(Input.GetKeyDown(KeyCode.UpArrow) && Inactive())
        {
            animator.Play("PlayerJumpPrep");
            jump = true;
        }

        //Set jump to false, so we don't repeat this condition. 
        //Set airborne true to prevent other actions
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("PlayerJump") && jump)
        {
            Debug.Log("jump");
            jump = false ;
            airborne = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 7f);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow) && Inactive())
        {
            roll = true;
            animator.Play("PlayerRoll");
        }

	}

    bool Inactive()
    {
        if (!jump && !roll && !airborne)
            return true;
        return false;
    }

    //Once we've collided with something, we're done jumping
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        jump = false;
    }
}
