using DG.Tweening;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] private SpriteMask mask;
    private int _orderMask;
    private Animal _animal;
    public Transform spawnPos;

    public bool IsOccupied() => _animal != null;

    public void PreSetup(int order)
    {
        _orderMask = order;
        mask.frontSortingOrder = _orderMask;
        mask.backSortingOrder = _orderMask - 1;
    }
    
    public void SetupAnimal(Animal animal)
    {
        if (_animal != null) return;
        _animal = animal;
        animal.SetupOrderLayer(_orderMask);
        animal.DoMove().OnComplete(OnCompletedMove);
    }

    private void OnCompletedMove()
    {
        if (_animal == null) return;
        Destroy(_animal.gameObject);
        _animal = null;
    }
}