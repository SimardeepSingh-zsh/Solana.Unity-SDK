using System.Runtime.InteropServices;
using UnityEngine;

// ReSharper disable once CheckNamespace

public class HyperlinkXnft : MonoBehaviour
{
    #if UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern void HyperlinkXNFT(string linkUrl);
    #else
    private static void HyperlinkXNFT(string linkUrl){}
    #endif


    public void OpenLink(string link)
    {
        //xnft link has to start with https:// and not have "www" after it. Very important!
    #if UNITY_EDITOR
        Application.OpenURL(link);
    #else
        Application.OpenURL(link);
        HyperlinkXNFT(link);
    #endif
    }


}
