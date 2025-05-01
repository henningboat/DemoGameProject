using DG.Tweening;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Door door;
    private bool isPressed;

    private void OnTriggerEnter(Collider other)
    {
        if (isPressed) return;
        isPressed = true;

        if (other.gameObject.GetComponent<Player>() == null) return;

        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOPunchScale(Vector3.one * 0.1f, .1f));
        sequence.AppendInterval(0.5f);
        sequence.Append(transform.DOMoveY(-1f, 1));
        sequence.AppendCallback(() => door.Open());
    }
}