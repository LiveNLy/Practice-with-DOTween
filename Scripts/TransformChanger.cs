using DG.Tweening;
using UnityEngine;

public class TransformChanger : Changer
{
    [SerializeField] protected Vector3 _vector3;
    [SerializeField] protected int _repeats;
    [SerializeField] protected LoopType _loopType;
}