using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _loopCount;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, _rotateMode)
            .SetLoops(_loopCount, _loopType);
    }
}