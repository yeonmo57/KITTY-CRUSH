using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoodDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //��ü���� �÷��̾ �ִ� ������ ��ȯ
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SecondTitleScene");
        }
    }
}
