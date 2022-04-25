using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBut : MonoBehaviour
{

    public float speedb = 5f, checkPosi = 0f;
    private RectTransform recb;

    void Start()
    {
        recb = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (recb.offsetMin.y != checkPosi)
        {
            recb.offsetMin += new Vector2(-recb.offsetMin.x, speedb);
            recb.offsetMax += new Vector2(-recb.offsetMax.x, speedb);
        }
    }
}
