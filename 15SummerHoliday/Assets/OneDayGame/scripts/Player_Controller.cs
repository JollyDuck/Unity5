using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {
    public float hozSpeed = 1;
    public enum facing : int { left, right };
    facing direction;
    public float jumpForce = 500;
    private bool jumping = false;
    public float jumpLimit = 0.0001f;
    private float oldY = -2f;
    GameObject me;
    //Transform trans;
    Rigidbody2D rb2;
	// Use this for initialization
	void Start ()
    {
        me = this.gameObject;
        rb2 = me.GetComponent<Rigidbody2D>();
        direction = facing.right;
        //trans = me.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void FixedUpdate()
    {

        //Move the character left, right, up or down

        float hoz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        
        if (hoz != 0f)
        {
            // move the char
            rb2.AddForce(new Vector2(hoz * hozSpeed, 0));
           // Debug.Log("Hoz = " + hoz + ", applying force.");

            //update which way facing

            direction = lookingWhichWay(hoz);
        }

        if(vert > 0f)
        {
            if (jumping == false)
            {
                jumping = true;
                Debug.Log("Set jumping = true");
                rb2.AddForce(new Vector2(0, jumpForce));
               // Debug.Log("Vert = " + vert + ", applying force.");
            }
       
        }

        // therefore jumping == true
        if (Mathf.Abs(oldY - transform.localPosition.y) < jumpLimit && jumping == true)
        {
            jumping = false;
            Debug.Log("Set jumping to false");
        }

        // Update storage variables

        oldY = transform.localPosition.y;


    }

    /**
    if int >= 0, facing right, else facing left.
    */
    private facing lookingWhichWay (float horiz)
    {
        if (horiz >= 0)
        {
            return facing.right;
        }
        else return facing.left;
    }
}
