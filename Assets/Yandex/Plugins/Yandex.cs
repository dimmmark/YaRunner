using System.Collections;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Yandex : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Hello();

    [DllImport("__Internal")]
    private static extern void GiveMePlayerData();

    [DllImport("__Internal")]
    private static extern void RateGame();

    [SerializeField] TextMeshProUGUI _nameText;
    [SerializeField] RawImage _photo;


    public void RateGameButton()
    {
        RateGame();
    }

    public void HelloButton()
    {
        GiveMePlayerData();
    }



    public void SetName(string name)
    {
        _nameText.text = name;
    }
    public void SetPhoto(string url)
    {
        StartCoroutine(DownloadImage(url));
    }
    IEnumerator DownloadImage(string madiaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(madiaUrl);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            Debug.Log(request.error);
        else
            _photo.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
    }
}
