using DG.Tweening;
using UnityEngine;

public class Scaler : TransformChanger
{
    private void Start()
    {
        transform.DOScale(_vector3, _duration).SetLoops(_repeats, _loopType);
    }
}