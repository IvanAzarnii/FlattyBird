using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiController : MonoBehaviour {
    public Button startBtn, settingsBtn;



    void Start () {

        Time.timeScale = 0;
        GameObject.Find("Setting").GetComponent<Canvas>().enabled = false;
        startBtn.GetComponent<Button>().onClick.AddListener(StartGame);
        settingsBtn.GetComponent<Button>().onClick.AddListener(OpenSettings);
        GameObject.Find("Bird_0").GetComponent<charcaterController>().enabled = false;
        GameObject.Find("Bird_0").GetComponent<SpriteRenderer>().enabled = false;

    }
    void StartGame()
    {
        GameObject.Find("Menu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Bird_0").GetComponent<charcaterController>().enabled = true;
        GameObject.Find("Bird_0").GetComponent<SpriteRenderer>().enabled = true;
        Time.timeScale = 1;
    }
    void OpenSettings()
    {
        GameObject.Find("Menu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Setting").GetComponent<Canvas>().enabled = true;

    }
}
