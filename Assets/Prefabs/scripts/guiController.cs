using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiController : MonoBehaviour {
    public Button startBtn, settingsBtn;
    GameObject player, toggle;
    public Sprite WhenOff, WhenOn;
    bool ismute;
    void Start () {
        toggle = GameObject.Find("soundToggle");
        toggle.GetComponent<Button>().onClick.AddListener(mute);
        player = GameObject.Find("Bird_0");
        Time.timeScale = 0;
        GameObject.Find("Setting").GetComponent<Canvas>().enabled = false;
        startBtn.GetComponent<Button>().onClick.AddListener(StartGame);
        settingsBtn.GetComponent<Button>().onClick.AddListener(OpenSettings);
        player.GetComponent<charcaterController>().enabled = false;
        player.GetComponent<SpriteRenderer>().enabled = false;
        ismute = false;
    }
    void mute()
    {
        if (!ismute)
        {
            GameObject.Find("Bird_0").GetComponent<AudioSource>().volume = 0f;
            GameObject.Find("bg").GetComponent<AudioSource>().volume = 0f;
            ismute = !ismute;
            GameObject.Find("soundToggle").GetComponent<Image>().sprite = WhenOff;
            Debug.Log(ismute);
        }
        else
        {
            GameObject.Find("Bird_0").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Volume");
            GameObject.Find("bg").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Volume");
            GameObject.Find("soundToggle").GetComponent<Image>().sprite = WhenOn;
            ismute = !ismute;
        }
    }
    void StartGame()
    {
        GameObject.Find("Menu").GetComponent<Canvas>().enabled = false;
        player.GetComponent<charcaterController>().enabled = true;
        player.GetComponent<SpriteRenderer>().enabled = true;
        Time.timeScale = 1;
    }
    void OpenSettings()
    {
        GameObject.Find("Menu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Setting").GetComponent<Canvas>().enabled = true;

    }
}
