using System;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace ChuongCustom
{
    public class InGameManager : Singleton<InGameManager>
    {
        [SerializeField] public int PriceToPrice = 1;

        private void Start()
        {
            ScoreManager.Reset();
        }

        [Button]
        public void Win()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.Result);
            //todo:
        }

        [Button]
        public void Lose()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.Lose);
            Time.timeScale = 0f;
            //todo:
        }

        [Button]
        public void BeforeLose()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.BeforeLose);
            //todo:
        }

        public void Retry()
        {
            //retry
            //todo:
        }

        public void Continue()
        {
            Time.timeScale = 1f;
        }

        private void OnEnable()
        {
            HoleController.Instance.Spawn();
            DOVirtual.DelayedCall(Random.Range(1f, 2f), () =>
            {
                HoleController.Instance.Spawn();
            }).SetLoops(-1).SetTarget(transform);
        }

        private void OnDisable()
        {
            transform.DOKill();
        }
    }
}