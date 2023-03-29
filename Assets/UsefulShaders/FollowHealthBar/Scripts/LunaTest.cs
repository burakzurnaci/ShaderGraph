using DG.Tweening;
using UnityEngine;

namespace UsefulShaders.FollowHealthBar.Scripts
{
    public class LunaTest : MonoBehaviour
    {
        public Material HeathBar;
        public Material HeathBar3D;
    
        public GameObject Cam;
        public GameObject Bar;

        private float _timeCounter = 0;

        private float _index=0;

        private float _index3D=-0.51f;
    
    
        private float _speed;
        private float _width;
        private float _height;
    
        void Start()
        {
            DOTween.To(()=> _index, x=> _index = x, 1, 1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
            _speed = 1;
            _width = 2;
            _height = 4;
            DOTween.To(()=> _index3D, x=> _index3D = x, 0.51f, 1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);

        }

        private void Update()
        {
            HeathBar.SetFloat("Fill", _index);
            HeathBar3D.SetFloat("Fill", _index3D);
            _timeCounter += Time.deltaTime*_speed;

            float x = Mathf.Sin(_timeCounter)*_height;
            float y = Mathf.Cos(_timeCounter)*_width;
            float z = 0;

            Cam.transform.position = new Vector3(x, y, z);
            Cam.transform.LookAt(Bar.transform.position);
        }
    }
}
