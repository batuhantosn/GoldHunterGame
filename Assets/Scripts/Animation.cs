using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    float time = 6f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time<0)
        {
            GetComponent<Animator>().Play(0);
            time = Random.Range(6,8);
        }
    }
}
