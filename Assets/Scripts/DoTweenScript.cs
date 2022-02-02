using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// DoTweenアニメーション
/// </summary>
public class DoTweenScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.DORotate(new Vector3(0, 360f, 0), 10f, RotateMode.WorldAxisAdd);

        transform.DORotate(new Vector3(0, 360, 0), 10f, RotateMode.LocalAxisAdd);
        //returnTitle.transform.DOLocalMoveY(0.5f,1f)/*.SetEase(Ease.InCubic)*/.SetLoops(2,LoopType.Yoyo).OnComplete(()=> { Debug.Log("owatta"); });
        //returnTitle.transform.DOLocalMoveY(0f,1f)/*.SetEase(Ease.InCubic)*/.SetRelative().SetLoops(10,LoopType.Yoyo);
       
    }
}
