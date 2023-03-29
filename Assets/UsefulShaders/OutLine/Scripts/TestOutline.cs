using DG.Tweening;
using UnityEngine;

namespace UsefulShaders.OutLine.Scripts
{
    public class TestOutline : MonoBehaviour
    {
        [SerializeField] private GameObject obj;
        // Start is called before the first frame update
        void Start()
        {
            obj.transform.DORotate(new Vector3(0, 200, 0), 2).SetLoops(-1, LoopType.Yoyo);
        }

  
    }
}
