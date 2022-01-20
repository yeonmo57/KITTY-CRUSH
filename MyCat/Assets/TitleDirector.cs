using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    // Start is called before the first frame update
   
    //메인 화면의 버튼의 기능
    //첫 화면에서 1라운드로 이동
    public void SceneChange()
    {
        SceneManager.LoadScene("RunGameScene");
    }

    //첫 화면에서 게임설명으로 이동
    public void SceneExplain()
    {
        SceneManager.LoadScene("HowtoScene");
    }

    //1라운드가 끝난뒤 두번 째 메인화면에서 2라운드로 이동
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
