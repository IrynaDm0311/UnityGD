using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public Sprite mus_on, mus_off;
    public float bigger=0.7f, lower=0.6f;

    void Start()
    {
        if(gameObject.name=="Settings")
        {
            if(PlayerPrefs.GetString("Music")==("off"))
            {
                transform.GetChild(0).gameObject.GetComponent<Image>().sprite = mus_off;
                Camera.main.GetComponent<AudioListener>().enabled = false; //switch off music
            }
        }
    }
    void OnMouseDown()
    {
        transform.localScale = new Vector3(bigger, bigger, bigger);
    }
    void OnMouseUp()
    {
        transform.localScale = new Vector3(lower, lower, lower);
    }
    void OnMouseUpAsButton()
    {
        GetComponent<AudioSource>().Play();
        switch(gameObject.name)
        {
            case "Restart":
                SceneManager.LoadScene("Main");
                break;
            case "Facebook":
                Application.OpenURL("https://www.facebook.com/login/");
                break;
            case "Settings":
                for (int i = 0; i < transform.childCount; i++)
                    transform.GetChild(i).gameObject.SetActive(!transform.GetChild(0).gameObject.activeSelf);
                break;
            case "Music":
                if(PlayerPrefs.GetString("Music")=="off")//Play music now
                {
                    GetComponent<Image>().sprite = mus_on;
                    PlayerPrefs.SetString("Music", "on");
                    Camera.main.GetComponent<AudioListener>().enabled = true; //switch on music
                }
                else //Off music
                {
                    GetComponent<Image>().sprite = mus_off;
                    PlayerPrefs.SetString("Music", "off");
                    Camera.main.GetComponent<AudioListener>().enabled = false; //switch off music
                }
                break;
        }
    }
}
