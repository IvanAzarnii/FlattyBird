using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class obstacleController : MonoBehaviour {

    Vector2 velocity = new Vector2(-4.0f, 0.0f);
    Rigidbody2D rg2d;
    float range;
    bool copied = false;
    public bool state = false;
    public Vector3 startpos;
    void Start()
    {
        range = Random.Range(-4.0f, 4.0f);
        Debug.Log(this.transform.position);
        Camera camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Vector3 startpos = camera.ViewportToWorldPoint(new Vector3(1 + 0.5f, 0.5f, camera.nearClipPlane));
        this.transform.position = new Vector3(startpos.x, startpos.y + range, 0);
        rg2d = this.GetComponent<Rigidbody2D>();
        rg2d.velocity = velocity;
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; ++i)
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), obstacles[i].GetComponent<Collider2D>());
        InvokeRepeating("CreateObstacles", 1.3f, 1.3f);
        
    }
    void Update()
    {
        if(copied)
        {
            CancelInvoke();
        }
    }
    void CreateObstacles()
    {
        Instantiate(this, new Vector3(startpos.x + 0.5f, startpos.y + range, 0), Quaternion.identity);
        copied = true;
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
