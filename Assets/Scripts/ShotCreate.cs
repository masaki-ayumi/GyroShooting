using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 弾を生成する
/// </summary>
public class ShotCreate : MonoBehaviour
{
    public GameObject shotCreate;
    public GameObject shotPrefab;

    GameObject audioObject;
    AudioScript audioScript;

    EffectScript effectScript;

    GameObject uiManager;
    UIManager uiManagerScript;

    public int timeCount = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        effectScript = this.GetComponent<EffectScript>();

        uiManager = GameObject.FindGameObjectWithTag("UIManager");
        uiManagerScript = uiManager.GetComponent<UIManager>();

        audioObject = GameObject.FindGameObjectWithTag("Audio");
        audioScript = audioObject.GetComponent<AudioScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       

        timeCount++;
        //JoyConのZRボタンもしくはマウスの左クリックで発射
        if (Input.GetMouseButton(0)||
            Input.GetKey(KeyCode.Joystick1Button0))
        {
          
            //弾を等間隔で発射
            if (timeCount % 6 == 0)
            {
                GameObject shot = Instantiate(shotPrefab, shotCreate.transform);
                Destroy(shot, 1.0f);
                effectScript.MuzzleFlashEffect();
                audioScript.MuzzleFlashSE();

            }
        }
    }
}
