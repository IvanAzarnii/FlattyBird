using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class obstacleController : MonoBehaviour {

    Vector2 velocity = new Vector2(-6.0f, 0.0f);
    Rigidbody2D rg2d;
    float range;
    public bool passed = false;

    void Start()
    {
        rg2d = this.GetComponent<Rigidbody2D>();
        rg2d.velocity = velocity;
        InvokeRepeating("CreateObstacles", 0.9f, 0.9f);
        range = Random.Range(-4.0f, 6.0f);
        GameObject ground = GameObject.Find("ground");
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), ground.GetComponent<Collider2D>());
    }
    void CreateObstacles()
    {
        Instantiate(this, new Vector3(24, 2 + range, 0), Quaternion.identity);
        Destroy(GetComponent<obstacleController>());

    }
}
