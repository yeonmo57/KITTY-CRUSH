using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    /*
    public SpriteRenderer[] tiles; //����ũ ������Ʈ�� ���� �迭
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
        // x�������� ���ݾ� �̵�
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        // ��ǥ ������ �����ߴٸ�
        if (transform.position.x <= endPosition)
        {
            ScrollEnd();
        }
    }

    void ScrollEnd()
    {
        // ���� ��ġ�� �ʱ�ȭ ��Ų��.
        transform.Translate(-1 * (endPosition - startPosition), 0, 0);
    }
}
