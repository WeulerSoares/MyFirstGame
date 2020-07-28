using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SawHorizontal : MonoBehaviour
{
    public float speed;
    public float moveTime;
    public bool dirRight;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if(timer >= moveTime)
        {
            dirRight = !dirRight;
            timer = 0f;
        }
    }
}
