using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LunaTest : MonoBehaviour
{
    public Material HeathBar;
    public GameObject Cam;
    public GameObject Bar;

    private float _timeCounter = 0;

    private float _index=0;
    
    
    private float _speed;
    private float _width;
    private float _height;
    
    void Start()
    {
        DOTween.To(()=> _index, x=> _index = x, 1, 1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
        _speed = 1;
        _width = 2;
        _height = 4;

    }

    private void Update()
    {
        HeathBar.SetFloat("Fill", _index);
        _timeCounter += Time.deltaTime*_speed;

        float x = Mathf.Sin(_timeCounter)*_height;
        float y = Mathf.Cos(_timeCounter)*_width;
        float z = 0;

        Cam.transform.position = new Vector3(x, y, z);
        Cam.transform.LookAt(Bar.transform.position);
    }
}
