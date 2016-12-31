using UnityEngine;
using System.Collections;
public class charcaterController : MonoBehaviour {

    Rigidbody2D body;
    Vector2 jump = new Vector2(0.0f, 800.0f);
    void Start () {

        body = this.GetComponent<Rigidbody2D>();
        
	}
	
	void Update () {
        OnKey();
                
	}
    void OnKey()
    {
        AudioSource audio = this.GetComponent<AudioSource>();
        if (/*Input.GetTouch(0).phase == TouchPhase.Stationary ||*/ Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = Vector2.zero;
            body.AddForce(jump);
            audio.Play();
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(coll.gameObject);
        Sce
    }
    /*void OnDestroy()
    {
        Time.timeScale = 0; 
    }*/
}
