using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [Header("Pipe Movement Speed")]
    public float moveSpeed = 3;
    [Header("Pipe Destroy Point")]
    public float pointXPosition = -1.35f;

    bool pointGiven = false;

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isGameOver && pointGiven == false && transform.position.x < pointXPosition)
        {
            GameManager.instance.GivePoint();
            pointGiven = true;
        }
        if (!GameManager.instance.isGameOver) { 
            transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
            if(transform.position.x < -5)
            {
                Destroy(gameObject);
            }
        }
    }
}
