using System.Collections;
using UnityEngine;

public class MusicCube : MonoBehaviour {

    public AudioClip cubeDrop;
    private bool firstOne;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Cube" && firstOne)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = GetComponent<MeshRenderer>().material.color;
            GetComponent<AudioSource>().clip = cubeDrop;
            GetComponent<AudioSource>().Play();
        }
        if(!firstOne)
        {
            firstOne = true;
        }
    }
}
