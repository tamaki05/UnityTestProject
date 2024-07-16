using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // public‚ÅéŒ¾‚µ‚½•Ï”‚ÍInspector‚ÅŒã‚©‚ç•ÏX‚Å‚«‚é
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // 1‰ñ‚¾‚¯Às
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        // ŒJ‚è•Ô‚µÀs
        transform.Translate(Vector3.forward * speed);
        Debug.Log(speed);
    }
}
