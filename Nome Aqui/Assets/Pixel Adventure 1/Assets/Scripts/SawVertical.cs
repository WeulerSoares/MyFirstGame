using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SawVertical : MonoBehaviour
{
    public float speed;
    public float moveTime;
    public bool dirDown;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        if (dirDown)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if (timer >= moveTime)
        {
            dirDown = !dirDown;
            timer = 0f;
        }
    }
}


