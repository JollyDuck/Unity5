using UnityEngine;
using UnityEngine.UI;

public class Player_stats : MonoBehaviour {
    Rigidbody2D rb2;
    public int playerHealth = 100;
    public int playerMana = 100;
    public float back_x = 500;
    public float back_y = -500;
    private Slider health_bar;
    private Slider mana_bar;

	// Use this for initialization
	void Start () {
        rb2 = gameObject.GetComponent<Rigidbody2D>();

        health_bar = GameObject.Find("Health_Slider").GetComponent<Slider>();
        health_bar.maxValue = playerHealth;

        mana_bar = GameObject.Find("Mana_Slider").GetComponent<Slider>();
        mana_bar.maxValue = playerMana;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        if (Input.GetAxis("Fire1") != 0)
        {
            Debug.Log("Fire 1" + Input.GetAxis("Fire1"));
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision with Enemy!");
            playerHealth -= 10;
            health_bar.value = playerHealth;


            rb2.velocity = new Vector3();
            rb2.AddForce(new Vector3(-back_x,-back_y));
            //TODO Player take damage
        }

    }


}
