using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    [Header("Pipe Related Variables")]
    public GameObject pipe;
    public float pipeInstantiateSecond = 1.5f;
    public GameObject pipeHolderParent;
    [Header("Bird Related Variables")]
    public GameObject birdObject;
    public Vector3 birdStartCoords = new Vector3(-0.74f, -0.67f, 0f);
    public Animator birdAnimator;
    [Header("UI Related Variables")]
    public GameObject canvasUI;
    public Text pointText;
    public int point = 0;
    [Header("Sound Manager")]
    public SoundManager soundManager;
    [Header("Game Over Status")]
    public bool isGameOver = false;
    



    private IEnumerator pipeCoroutine;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        pipeCoroutine = pipeInstantiater();
        StartCoroutine("pipeInstantiater");
        if(pointText != null)
        {
            pointText.text = "Point: " + point;
        }
      
    }


    void Update()
    {
        if(canvasUI != null)
        {
            if (isGameOver && canvasUI.activeSelf != true)
            {
                canvasUI.SetActive(true);
            }
        }
       
    }

    IEnumerator pipeInstantiater()
    {
        GameObject instantiatedFirstPipe = Instantiate(pipe, new Vector3(5.85f, Random.Range(-3.5f, 2.5f), 0), Quaternion.identity);
        instantiatedFirstPipe.transform.parent = pipeHolderParent.transform;
        while (!isGameOver)
        {
            yield return new WaitForSeconds(pipeInstantiateSecond);
            GameObject instantiatedPipe = Instantiate(pipe, new Vector3(5.85f, Random.Range(-3.5f, 2.5f), 0), Quaternion.identity);
            instantiatedPipe.transform.parent = pipeHolderParent.transform;
        }
    }

    public void PlayAgain() {
        StopCoroutine("pipeInstantiater");
        foreach (Transform pipe in pipeHolderParent.transform)
        {
            Destroy(pipe.gameObject);
        }
       
        birdObject.transform.position = birdStartCoords;
        isGameOver = false;
        point = 0;
        pointText.text = "Point: " + point;
        if(birdAnimator != null)
        {
            birdAnimator.SetTrigger("Born");
        }
        
        canvasUI.SetActive(false);
        StartCoroutine("pipeInstantiater");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GivePoint()
    {
        if(soundManager != null)
        {
            soundManager.PlayOneShotHelper(soundManager.point);
        }
       
        point++;
        if(pointText != null)
        {
            pointText.text = "Point: " + point;
        }
       
    }
}
