using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiController : MonoBehaviour {
    public Button startBtn, settingsBtn;
    GameObject pl;


    void Start () {
        pl = GameObject.Find("Bird_0");
        Time.timeScale = 0;
        GameObject.Find("Setting").GetComponent<Canvas>().enabled = false;
        startBtn.GetComponent<Button>().onClick.AddListener(StartGame);
        settingsBtn.GetComponent<Button>().onClick.AddListener(OpenSettings);
        pl.GetComponent<charcaterController>().enabled = false;
        pl.GetComponent<SpriteRenderer>().enabled = false;

    }
    void StartGame()
    {
        GameObject.Find("Menu").GetComponent<Canvas>().enabled = false;
        pl.GetComponent<charcaterController>().enabled = true;
        pl.GetComponent<SpriteRenderer>().enabled = true;
        Time.timeScale = 1;
    }
    void OpenSettings()
    {
        GameObject.Find("Menu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Setting").GetComponent<Canvas>().enabled = true;

    }
}
