using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Material blur;
    
    private float _index=0;
    void Start()
    {
        DOTween.To(()=> _index, x=> _index = x, 0.008f, 1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
    }

    private void Update()
    {
        blur.SetFloat("Blur", _index);
    }
}
