using UnityEngine;
using DG.Tweening;

public class Mover : TransformChanger
{
    private void Start()
    {
        transform.DOMove(_vector3, _duration).SetLoops(_repeats, _loopType);
    }
}