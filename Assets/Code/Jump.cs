using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public float JumpSpeed = 240f;
    private bool HasJumped = false;
    private Rigidbody2D body2d;
 
	// Use this for initialization
	void Awake() {

        body2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
            if (HasJumped == false && Input.GetKeyDown("space"))
            {
                body2d.velocity = new Vector2(0, JumpSpeed);
            }
        }
	}

