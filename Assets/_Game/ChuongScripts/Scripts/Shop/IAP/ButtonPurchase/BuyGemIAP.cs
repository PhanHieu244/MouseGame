using UnityEngine;

namespace ChuongCustom
{
    public class BuyGemIAP : ValuePurchase
    {
        protected override void Setup()
        {
        }

        protected override void OnPurchaseSuccess()
        {
            
        }

        protected override void Click()
        {
            ToastManager.Instance.ShowMessageToast("Buy Success!!");
            Data.Player.Gem += Value;
        }
    }
}