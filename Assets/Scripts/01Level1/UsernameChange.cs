using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class UsernameChange : MonoBehaviour
{
    [SerializeField] Text _usernameText,_usernameText2;
    [SerializeField] InputField _usernameIF;

    public void GetUsername()
    {
        PlayFabClientAPI.GetAccountInfo(new GetAccountInfoRequest() {}, Result => { _usernameText.text= Result.AccountInfo.TitleInfo.DisplayName; Debug.Log("Username cekildi"); _usernameText2.text = _usernameText.text; }, Error => { Debug.Log("Username celikemedi"); }) ;
    }

    public void ChangeUsername()
    {
        PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest() { DisplayName = _usernameIF.text}, Result => { Debug.Log("kullanici adi degistirildi");_usernameText.text = _usernameIF.text;_usernameText2.text = _usernameIF.text; }, Error => { Debug.Log("kullanici adi degistirilemedi"); });
    }

    private void Awake()
    {
        GetUsername();
        
    }

}
