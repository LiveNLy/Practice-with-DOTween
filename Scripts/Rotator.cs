using DG.Tweening;
using UnityEngine;

public class Rotator : TransformChanger
{
    [SerializeField] private RotateMode _rotateMode;

    private void Start()
    {
        transform.DORotate(_vector3, _duration, _rotateMode)
            .SetLoops(_repeats, _loopType);
    }
}