using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    // Start is called before the first frame update
   
    //���� ȭ���� ��ư�� ���
    //ù ȭ�鿡�� 1����� �̵�
    public void SceneChange()
    {
        SceneManager.LoadScene("RunGameScene");
    }

    //ù ȭ�鿡�� ���Ӽ������� �̵�
    public void SceneExplain()
    {
        SceneManager.LoadScene("HowtoScene");
    }

    //1���尡 ������ �ι� ° ����ȭ�鿡�� 2����� �̵�
    public void SceneSecondRound()
    {
        SceneManager.LoadScene("SecondRound");
    }

 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
