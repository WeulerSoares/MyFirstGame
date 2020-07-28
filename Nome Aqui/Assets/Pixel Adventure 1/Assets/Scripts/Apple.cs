using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public bool isCollected;

    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (!isCollected)
        {
            if(collider.gameObject.tag == "Player")
            {
                isCollected = true;
                GameController.instance.UpdateScoreText();

                sr.enabled = false;
                circle.enabled = false;
                collected.SetActive(true);

                Destroy(gameObject, 0.5f);
            }
        }

    }
}
