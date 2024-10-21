#if UNITY_IPHONE
using System.Runtime.InteropServices;

namespace AppodealAds.Unity.iOS
{
    [StructLayout(LayoutKind.Sequential)]
    public struct InAppPurchaseParams
    {
        public string productIdentifier;
        public string price;
        public string currency;
        public string transactionId;
        public string additionalParams;
        public int type;
    }
}
#endif