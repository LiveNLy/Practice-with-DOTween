using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private void Start()
    {
        _text.DOText("¬¿”, ﬂ Ã≈Õﬂﬁ—‹", _duration, true, ScrambleMode.All);
    }
}