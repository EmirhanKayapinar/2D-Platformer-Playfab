using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class AvatarChangeControl : MonoBehaviour
{
    string url;
    [SerializeField] GameObject _avatar1, _avatar2, _avatar3, _avatar4,_avatar1oc,_avatar2oc,_avatar3oc,_avatar4oc;
    public bool Avatar_Async;
    public void GetAvatarUrl()
    {
        PlayFabClientAPI.GetAccountInfo(new GetAccountInfoRequest() { },
            Result =>
            {
                Debug.Log(url);
                url = Result.AccountInfo.TitleInfo.AvatarUrl; if (url == "https://www.gravatar.com/userimage/221184320/33280c8e064d8b98c7a52823bff77d41?size=120")
                {
                    _avatar1.SetActive(true);
                    _avatar2.SetActive(false);
                    _avatar3.SetActive(false);
                    _avatar4.SetActive(false);
                }

                else if (url == "https://www.gravatar.com/userimage/221184320/3ab42c6e9110f8e07079552bbb5ccc61?size=120")
                {
                    _avatar1.SetActive(false);
                    _avatar2.SetActive(true);
                    _avatar3.SetActive(false);
                    _avatar4.SetActive(false);
                }

                else if (url == "https://www.gravatar.com/userimage/221184320/dd955ba9a4c1d733195fa935c4495b9b?size=120")
                {
                    _avatar1.SetActive(false);
                    _avatar2.SetActive(false);
                    _avatar3.SetActive(true);
                    _avatar4.SetActive(false);
                }
                else if (url == "https://www.gravatar.com/userimage/221184320/63b1aef8ae04c5f0741eb71458ee5791?size=120")
                {
                    _avatar1.SetActive(false);
                    _avatar2.SetActive(false);
                    _avatar3.SetActive(false);
                    _avatar4.SetActive(true);
                }

            }, 
            
            Error => { });
    }

    public void Avatar1Onclick()
    {
        _avatar1oc.SetActive(true);
        _avatar2oc.SetActive(false);
        _avatar3oc.SetActive(false);
        _avatar4oc.SetActive(false);
    }
    public void Avatar2Onclick()
    {
        _avatar1oc.SetActive(false);
        _avatar2oc.SetActive(true);
        _avatar3oc.SetActive(false);
        _avatar4oc.SetActive(false);
    }
    public void Avatar3Onclick()
    {
        _avatar1oc.SetActive(false);
        _avatar2oc.SetActive(false);
        _avatar3oc.SetActive(true);
        _avatar4oc.SetActive(false);
    }

    public void Avatar4Onclick()
    {
        _avatar1oc.SetActive(false);
        _avatar2oc.SetActive(false);
        _avatar3oc.SetActive(false);
        _avatar4oc.SetActive(true);
    }

    private void Awake()
    {
        GetAvatarUrl();
    }

    IEnumerator AsyncControl()
    {
        if (_avatar1oc.activeInHierarchy)
        {
            url = "https://www.gravatar.com/userimage/221184320/33280c8e064d8b98c7a52823bff77d41?size=120";
        }

        else if (_avatar2oc.activeInHierarchy)
        {
            url = "https://www.gravatar.com/userimage/221184320/3ab42c6e9110f8e07079552bbb5ccc61?size=120";
        }

        else if (_avatar3oc.activeInHierarchy)
        {
            url = "https://www.gravatar.com/userimage/221184320/dd955ba9a4c1d733195fa935c4495b9b?size=120";
        }
        else if (_avatar4oc.activeInHierarchy)
        {
            url = "https://www.gravatar.com/userimage/221184320/63b1aef8ae04c5f0741eb71458ee5791?size=120";
        }

        PlayFabClientAPI.UpdateAvatarUrl(new UpdateAvatarUrlRequest() { ImageUrl = url}, Result => { Avatar_Async = true; }, Error => { Avatar_Async = false; });

        yield return new WaitUntil(() => Avatar_Async);

        GetAvatarUrl();

        Debug.Log("Görsel degistirildi");
    }

    public void ChangeAvatarImageOnClick()
    {
        StartCoroutine(AsyncControl());
    }
}
