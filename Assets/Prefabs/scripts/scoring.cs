using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoring : MonoBehaviour {

    GameObject player;
    GameObject[] obstacles;
    int score = 0;
    void Start () {
        player = GameObject.Find("Bird_0");
       GameObject.Find("points").GetComponent<Text>().text = score.ToString();
    }
    void Update()
    {
        obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; ++i)
        {
            
            
            if (player.transform.position.x > obstacles[i].transform.position.x && !obstacles[i].GetComponent<obstacleController>().state)
            {
                score++;
                obstacles[i].GetComponent<obstacleController>().state = true;
                GameObject.Find("points").GetComponent<Text>().text = score.ToString();
                
            }
        }
    }
}
