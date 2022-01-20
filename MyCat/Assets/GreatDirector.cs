using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreatDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //엔딩화면으로 전환
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
