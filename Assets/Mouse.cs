using ChuongCustom;
using UnityEngine;

public class Mouse : Animal
{
    [SerializeField] private int score = 10;
    
    public override void OnClick()
    {
        ScoreManager.Score += score;
    }
}