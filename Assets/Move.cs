using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // public�Ő錾�����ϐ���Inspector�Ōォ��ύX�ł���
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // 1�񂾂����s
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        // �J��Ԃ����s
        transform.Translate(Vector3.forward * speed);
        Debug.Log(speed);
    }
}
