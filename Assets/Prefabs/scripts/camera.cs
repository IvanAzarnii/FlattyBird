using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public float targetAspect;

    void Start()
    {
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;
        Camera camera = GameObject.Find("Main Camera").GetComponent<Camera>();

        if (scaleHeight < 1.0f)
        {
            camera.orthographicSize = camera.orthographicSize / scaleHeight;
        }
    }
}
