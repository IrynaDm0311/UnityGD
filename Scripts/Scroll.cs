using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float speed = 5f, checkPos = 0f;
    private RectTransform rec;

    void Start()
    {
        rec = GetComponent<RectTransform>();
    }

    void Update()
    {
        if(rec.offsetMin.y!=checkPos)
        {
            rec.offsetMin += new Vector2(0f, speed);
            rec.offsetMax += new Vector2(0f, speed);
        }
    }
}
