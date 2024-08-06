using DG.Tweening;
using UnityEngine;

public abstract class Animal : MonoBehaviour, IAnimal, IClickable
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite normal, stunned;
    [SerializeField] private float high, speed, timeWait;
    private bool _isClicked;
    
    private void OnEnable()
    {
        _isClicked = false;
        spriteRenderer.sprite = normal;
    }

    public abstract void OnClick();

    private void OnMouseDown()
    {
        if (_isClicked) return;
        _isClicked = true;
        spriteRenderer.sprite = stunned;
        OnClick();
    }

    public Tween DoMove()
    {
        var start = transform.localPosition.y;
        var target = high + start;
        return DOTween.Sequence(transform)
            .Append(transform.DOLocalMoveY(target, high / speed))
            .AppendInterval(timeWait)
            .Append(transform.DOLocalMoveY(start, high / speed));
    }

    public void SetupOrderLayer(int order)
    {
        spriteRenderer.sortingOrder = order;
    }
}