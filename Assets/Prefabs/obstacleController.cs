using UnityEngine;
using System.Collections;

public class obstacleController : MonoBehaviour {

    Vector2 velocity = new Vector2(-9.0f, 0.0f);
    Rigidbody2D rg2d;
    float range;


    void Start()
    {
        rg2d = this.GetComponent<Rigidbody2D>();
        rg2d.velocity = velocity;
        InvokeRepeating("CreateObstacles", 0.8f, 0.8f);
        range = Random.Range(-5.0f, 5.0f);
    }
    void CreateObstacles()
    {
        Instantiate(this, new Vector3(35, 5 + range, 0), Quaternion.identity);
        Destroy(GetComponent<obstacleController>());

    }
    void Update()
    {

    }
}
