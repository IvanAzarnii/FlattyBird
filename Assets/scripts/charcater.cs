using UnityEngine;
using System.Collections;
public class charcater : MonoBehaviour {

    Rigidbody2D body;
    AudioSource flap;


	void Start () {
        body = this.GetComponent<Rigidbody2D>();
        
	}
	
	void Update () {
        OnKey();
                
	}
    void OnKey()
    {
        AudioSource audio = this.GetComponent<AudioSource>();
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            body.velocity = new Vector2(0.0f, 17.0f * (Time.deltaTime * 60.0f));
            audio.Play();
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            body.velocity = new Vector2(0.0f, -6.0f * (Time.deltaTime * 15.0f));
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Happend!1");
        Destroy(GameObject.FindGameObjectWithTag("Finish"));
    }
}
