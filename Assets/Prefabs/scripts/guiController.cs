using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiController : MonoBehaviour {
    public Button btn1;
    
    void Start () {
        btn1 = GameObject.Find("StartBtn").GetComponent<Button>();
        Button btn = btn1.GetComponent<Button>();
        btn1.onClick.AddListener(Task);

    }
    void Task()
    {
        Application.LoadLevel("MainScene");
    }

}
