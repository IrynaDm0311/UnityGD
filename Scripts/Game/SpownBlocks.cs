using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownBlocks : MonoBehaviour {

    public GameObject block, allCubes;
    private GameObject blockInst;
    private Vector3 blockPos;
    private float speed = 6f;
    private bool onPlace;

	void Start ()
    {
        Spawn();
    }

    void Update()
    {
        if(blockInst.transform.position!=blockPos && !onPlace)
        {
            blockInst.transform.position = Vector3.MoveTowards(blockInst.transform.position, blockPos, Time.deltaTime*speed);
        }
        else if (blockInst.transform.position == blockPos)
        {
            onPlace = true;
        }
        if(CubeJump.jump && CubeJump.nextBlock)
        {
            Spawn();

            onPlace = false;
        }
    }

    float RandScale()
    {
        float rand;
        if(Random.Range(0,100)>80)
        {
            rand = Random.Range(1.2f, 2f);
        }
        else
        {
            rand = Random.Range(1.2f, 1.5f);
        }
        return rand;
    }

    void Spawn()
    {
        blockPos = new Vector3(Random.Range(0.7f, 1.7f), -Random.Range(0.6f, 3.2f), 0f);
        blockInst = Instantiate(block, new Vector3(5f, -6f, 0), Quaternion.identity);
        blockInst.transform.localScale = new Vector3(RandScale(), blockInst.transform.localScale.y, blockInst.transform.localScale.z);
        blockInst.transform.parent = allCubes.transform;
    }
}
