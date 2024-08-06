using ChuongCustom;

public class Kitten : Animal
{
    public override void OnClick()
    {
        InGameManager.Instance.Lose();
    }
}