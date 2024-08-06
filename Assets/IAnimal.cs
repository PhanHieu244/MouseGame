using _Game.ChuongScripts;
using DG.Tweening;

public interface IAnimal
{
    Tween DoMove();
    void SetupOrderLayer(int order);
}