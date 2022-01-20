using System.Collections;
using System.Collections.Generic;
//using System.Threading;
//using System.Security.Cryptography;
using UnityEngine;

public class cakeGenerator : MonoBehaviour
{
    /*
    public float speed = 1.0f;
    public float startPosition = -6.5f;
    public float endPosition = 5;
    public GameObject cakePrefab;
    //float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Instantiate(cakePrefab) as GameObject;
        go.transform.position = new Vector3(-6.5f, -3.8f, 0);       
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        this.transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        
        if(transform.position.x <= endPosition)
        {
            ScrollEnd();
        }

        void ScrollEnd()
        {
            transform.Translate(-1 * (endPosition - startPosition), 0, 0);
        }

    }
    /*
    public GameObject cakePrefab;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(cakePrefab) as GameObject;
            go.transform.position = new Vector3(-6.5f, -3.8f, 0);
        }
    }
    */


}
