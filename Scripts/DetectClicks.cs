using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectClicks : MonoBehaviour {

    public GameObject buttons, m_cube, seccub, spownblocks, music;
    public Text playTxt, gameName, study, record;
    public Light dirLight, dirLight_2;

    private bool clicked;

    void Update()
    {
        if(clicked && dirLight.intensity != 0)
        {
            dirLight.intensity -= 0.03f;
        }
        if (clicked && dirLight_2.intensity >= 1.05f)
        {
            dirLight_2.intensity -= 0.025f;
        }

    }
    void OnMouseDown()
    {
        if (!clicked)
        {
            clicked = true;//works only once
            playTxt.gameObject.SetActive(false);
            study.gameObject.SetActive(true);
            record.gameObject.SetActive(true);
            //Hide settings if active
            if(music.activeSelf)
            {
                for (int i = 0; i < music.transform.parent.transform.childCount; i++)
                    music.transform.parent.transform.GetChild(i).gameObject.SetActive(!music.transform.parent.transform.GetChild (i).gameObject.activeSelf);
            }
            gameName.text = "0";
            buttons.GetComponent<ScrollBut>().speedb = -5f;
            buttons.GetComponent<ScrollBut>().checkPosi = -125f;
            m_cube.GetComponent<Animation>().Play("StarGameCube");
            seccub.GetComponent<Animation>().Play("SecCube");
            spownblocks.GetComponent<SpownBlocks>().enabled = true;
            m_cube.AddComponent<Rigidbody>();
        }
        else if(clicked && study.gameObject.activeSelf)
        {
            study.gameObject.SetActive(false);
        }
    }
}
