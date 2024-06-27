using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [Header("How Fast Bird Will Jump")]
    public float pushVelocity = 5;
    [Header("Rotation Related Variables")]
    public float upRotationValue = 25;
    public float downRotationValue = -70;
    public float downRotationDecreaseValue = 2;
    public float downRotationWaitTime = 0.75f;
    [Header("Rigidbody")]
    public Rigidbody2D rb;
    [Header("Bird Y Coordinate Limit")]
    public float borderYCoord = 5.95f;
    [Header("Animator")]
    public Animator animator;
    float rotationTimer = 0f; 
   
    SoundManager soundManager;

    void Start()
    {
        soundManager = GameManager.instance.soundManager;
    }

    void Update()
    {
        if(!GameManager.instance.isGameOver)
        {
            StayOnBorders();
            if (Input.GetMouseButtonUp(0) || Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended))
            {
                PushUp();
            }
        }

        rotationTimer += Time.deltaTime;
        //to calculate negative value of rotation z
        float zAngle = CalculateNegativeZValue();

            //if time has passed and rotation z value not too low decrease the rotation z value
            if (rotationTimer > downRotationWaitTime && zAngle > downRotationValue)
            {
                transform.Rotate(new Vector3(0f, 0f, -downRotationDecreaseValue));
            }
        
    }

    void PushUp()
    {
        if(soundManager != null)
        {
            soundManager.PlayOneShotHelper(soundManager.wings);
        }

        rb.velocity = (new Vector2(0, pushVelocity));
        rotationTimer = 0f;
        transform.eulerAngles = new Vector3(0f, 0f, upRotationValue);
    }
    //to calculate negative value of rotation z
    float CalculateNegativeZValue()
    {
        float zAngle = transform.localEulerAngles.z;
        zAngle = (zAngle > 180) ? zAngle - 360 : zAngle;
        return zAngle;
    }

    void OnCollisionEnter2D()
    {
        if (!GameManager.instance.isGameOver) {
            if(soundManager != null)
            {
                soundManager.PlayOneShotHelper(soundManager.hit);
                soundManager.PlayOneShotHelper(soundManager.die);
            }
            GameManager.instance.isGameOver = true;
            if(animator != null)
            {
                animator.SetTrigger("Die");
            }
            
        }
    }

    void StayOnBorders()
    {
        if(transform.position.y > borderYCoord)
        {
            transform.position = new Vector3(transform.position.x, borderYCoord, transform.position.z);
        }
    }
}
