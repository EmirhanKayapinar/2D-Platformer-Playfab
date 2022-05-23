using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginBase 
{
    public bool LoginAsync;
    public void LoginEmail(InputField _email, InputField _password)
    {
        PlayFabClientAPI.LoginWithEmailAddress(new LoginWithEmailAddressRequest() { Email = _email.text, Password = _password.text}, 
            Result => { Debug.Log("Email Giris Basarili");LoginAsync = true;}, 
            Error => { Debug.Log("Email Giris Basarisiz"); LoginAsync = false; });
    }

    public void LoginUsername(InputField _username, InputField _password)
    {
        PlayFabClientAPI.LoginWithPlayFab(new LoginWithPlayFabRequest() { Username = _username.text,Password= _password.text }, 
            Result => { LoginAsync = true; }, Error => { Debug.Log("Username Giris Basarisiz"); LoginAsync = false; }); ;
    }

    public void SwitchEmailUsername(InputField _emailUsername, InputField _password)
    {
        switch (_emailUsername.text.IndexOf('@')>0)
        {
            case true:
                LoginEmail(_emailUsername,_password);
                Debug.Log("email basarili");
                break;
            default:
                LoginUsername(_emailUsername, _password);
                Debug.Log("username basarili");
                break;
        }
    }

    public void LoginGuest(bool _guestLogin)
    {
        PlayFabClientAPI.LoginWithAndroidDeviceID(new LoginWithAndroidDeviceIDRequest() { AndroidDeviceId = SystemInfo.deviceUniqueIdentifier,CreateAccount = _guestLogin }, Result => { Debug.Log("Misafir girisi basarili"); SceneManager.LoadScene(1); }, Error => { Debug.Log("Misafir girisi basarisiz"); });
    }

    




}
