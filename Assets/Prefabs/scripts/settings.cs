using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class settings : MonoBehaviour {

    Slider reg;
    public Button playbtn;

    void Start () {
        reg = GameObject.Find("Volumer").GetComponent<Slider>();
        reg.value = PlayerPrefs.GetFloat("Volume"); 
        reg.onValueChanged.AddListener(delegate { SaveSets(); });
        playbtn.onClick.AddListener(Play);

    }
    void Play()
    {
        Time.timeScale = 1;
        GameObject.Find("Setting").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Bird_0").GetComponent<charcaterController>().enabled = true;
        GameObject.Find("Bird_0").GetComponent<SpriteRenderer>().enabled = true;
    }
    void SaveSets()
    {
        GameObject.Find("bg").GetComponent<AudioSource>().volume = reg.value;      
        PlayerPrefs.SetFloat("Volume", reg.value);
        PlayerPrefs.Save();
    }
}
