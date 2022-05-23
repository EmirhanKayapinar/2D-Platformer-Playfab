using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;


public class RegisterBase 
{
    public bool Register_Async;
    public void RegisterOnClick(string _email,string _password,string _username)
    {
        PlayFabClientAPI.RegisterPlayFabUser(new RegisterPlayFabUserRequest() {Username = _username, Password = _password, Email = _email, DisplayName=_username }, 
            Result => { Register_Async = true;}, 
            Error => {Debug.Log("Basarisiz");Register_Async = false; });
    }

}
