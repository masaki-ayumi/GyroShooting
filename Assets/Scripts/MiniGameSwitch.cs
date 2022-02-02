using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameSwitch : MonoBehaviour
{
    private GameObject uiManager;
    private UIManager uiManagerScript;

    private GameObject switchObject;

    private bool isStartMiniGame = false;

    //public bool isActive = true;

    private GameObject target;
    private Vector3 targetPosition;

    private GameObject score;
    private GameObject time;

    private GameObject returnTitle;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindGameObjectWithTag("UIManager");
        uiManagerScript = uiManager.GetComponent<UIManager>();

        target = GameObject.FindGameObjectWithTag("Target");
        targetPosition = target.transform.position;

        switchObject = GameObject.FindGameObjectWithTag("Switch");

        returnTitle = GameObject.FindGameObjectWithTag("ReturnTitle");

        score = GameObject.FindGameObjectWithTag("Score");
        time = GameObject.FindGameObjectWithTag("Time");

        score.SetActive(false);
        time.SetActive(false);

        switchObject.SetActive(true);

        returnTitle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (uiManagerScript.isStoopde == true)
        {
            switchObject.SetActive(true);

            returnTitle.SetActive(true);
            time.SetActive(false);
        }
    }

    public void IsHit(bool hit)
    {
        if (hit)
        {
            uiManagerScript.isStoopde = false;

            target.transform.position = targetPosition;

            isStartMiniGame = true;
            uiManagerScript.isStartMiniGame = isStartMiniGame;

            score.SetActive(true);
            time.SetActive(true);

            switchObject.SetActive(false);
            returnTitle.SetActive(false);
        }

    }
   
}
