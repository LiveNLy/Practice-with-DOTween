using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : Changer
{
    [SerializeField] private Text _text;

    private Sequence _sequence;

    private void Start()
    {
        _sequence = DOTween.Sequence();

        _sequence.Append(_text.DOText("���, � �������", _duration))
            .Append(ChangeText())
            .Append(_text.DOText("���, � �����", _duration, true, ScrambleMode.All))
            .PrependInterval(1);
    }

    private Tween ChangeText()
    {
        return _text.DOText("\n�����", _duration).SetRelative();
    }
}