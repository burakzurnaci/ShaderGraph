using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class AlphaTest : MonoBehaviour
{

    [SerializeField] private Material mat;

    private float alphaValue=0;


    private void Start()
    {
        DOTween.To(()=> alphaValue, x=> alphaValue = x, 1, 1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
    }


    // Update is called once per frame
    void Update()
    {
        mat.SetFloat("_Factor",alphaValue);
    }
}
