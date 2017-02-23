using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class charcaterController : MonoBehaviour {

    Rigidbody2D body;
    Vector2 jump = new Vector2(0.0f, 800.0f);
    void Start () {
        Debug.Log(PlayerPrefs.GetFloat("Volume"));
        GameObject.Find("bg").GetComponent<AudioSource>().Play();
        body = this.GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        OnKey();
                
	}
    void OnKey()
    {
        if (Input.anyKeyDown)
        {
            body.velocity = Vector2.zero;
            body.AddForce(jump);
            
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Obstacle")
        {
            Destroy(this);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

    }
    void OnDestroy()
    {
        int auto = System.Convert.ToInt32(GameObject.Find("points").GetComponent<Text>().text);
        if(auto > PlayerPrefs.GetInt("MaxScore"))
        {
            PlayerPrefs.SetInt("MaxScore", auto);
            PlayerPrefs.Save();
            
        }
    }
}
