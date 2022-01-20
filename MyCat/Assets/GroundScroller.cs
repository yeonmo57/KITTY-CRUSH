using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    /*
    public SpriteRenderer[] tiles; //케이크 오브젝트를 담을 배열
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0; i<tiles.Length; i++)
        {
            tiles[i].transform.Translate(new Vector2(-1, 0) * Time.deltaTime *speed);
        }
    }*/

    public float speed = 1.0f;
    public float startPosition;
    public float endPosition;

    void Update()
    {
        // x포지션을 조금씩 이동
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        // 목표 지점에 도달했다면
        if (transform.position.x <= endPosition)
        {
            ScrollEnd();
        }
    }

    void ScrollEnd()
    {
        // 원래 위치로 초기화 시킨다.
        transform.Translate(-1 * (endPosition - startPosition), 0, 0);
    }
}
