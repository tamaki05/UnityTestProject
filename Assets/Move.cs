using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // publicで宣言した変数はInspectorで後から変更できる
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // 1回だけ実行
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        // 繰り返し実行
        transform.Translate(Vector3.forward * speed);
        Debug.Log(speed);
    }
}
