using DG.Tweening;
using UnityEngine;

public class Collorer : Changer
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _color;

    private void Start()
    {
        _spriteRenderer.DOColor(_color, _duration);
    }
}