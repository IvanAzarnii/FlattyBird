using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class obstacleController : MonoBehaviour {

    Vector2 velocity = new Vector2(-6.0f, 0.0f);
    Rigidbody2D rg2d;
    float range;
    bool copied = false;
    public bool state = false;
    void Start()
    {
        rg2d = this.GetComponent<Rigidbody2D>();
        rg2d.velocity = velocity;
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; ++i)
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), obstacles[i].GetComponent<Collider2D>());
        InvokeRepeating("CreateObstacles", 1.2f, 1.2f);

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
        range = Random.Range(-4.0f, 6.0f);
        Instantiate(this, new Vector3(22, 2 + range, 0), Quaternion.identity);
        copied = true;
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
