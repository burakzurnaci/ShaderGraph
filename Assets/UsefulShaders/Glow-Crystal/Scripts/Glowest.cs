using DG.Tweening;
using UnityEngine;

namespace UsefulShaders.Glow_Crystal.Scripts
{
    public class Glowest : MonoBehaviour
    {
        [SerializeField] private Material[] glowMaterials;
    
        [SerializeField] private float[] _index;
    
        private void Start()
        {
       
            DOTween.To(()=> _index[0], x=> _index[0] = x, 1, 2).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
            DOTween.To(()=> _index[1], x=> _index[1] = x, 1, 1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
            DOTween.To(()=> _index[2], x=> _index[2] = x, 1, 0.5f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
            DOTween.To(()=> _index[3], x=> _index[3] = x, 1, 1.5f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);

        }

        private void Update()
        {
            glowMaterials[0].SetFloat("_Top", _index[0]);
            glowMaterials[1].SetFloat("_Top", _index[1]);
            glowMaterials[2].SetFloat("_Top", _index[2]);
            glowMaterials[3].SetFloat("_Top", _index[3]);
        }
    }
}
