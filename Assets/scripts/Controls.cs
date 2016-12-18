using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

    Rigidbody2D body;


	void Start () {

        body = this.GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
        OnKey();
        
	}
    void OnMTouch()
    {

    }
    void OnKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            body.velocity = new Vector2(8.0f, 17.0f * (Time.deltaTime * 60.0f));
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            body.velocity = new Vector2(8.0f, -6.0f * (Time.deltaTime * 15.0f));
        }
    }
}
