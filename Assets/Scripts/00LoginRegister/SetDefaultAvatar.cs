using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class SetDefaultAvatar 
{

    public void SetDefaultAvatarImage(string _url)
    {
        PlayFabClientAPI.UpdateAvatarUrl(new UpdateAvatarUrlRequest() {ImageUrl= _url  }, Result => { Debug.Log("resim yüklendi"); }, Error => { Debug.Log("Resim yüklenemedi"); });
    }








}
