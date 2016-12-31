using UnityEngine;
using System.Collections;

public class obstacleRemover : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(coll.gameObject);
        this.transform.position = new Vector3(-30.99f, -10.96f, 0);

    }
}
