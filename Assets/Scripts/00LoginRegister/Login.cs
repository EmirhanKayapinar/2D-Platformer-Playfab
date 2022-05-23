using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    LoginBase _loginBase;
    [SerializeField] InputField _email, _password;
    [SerializeField] bool _guestLogin;
    [SerializeField] GameObject _asyncPanel;
    [SerializeField] Text _asyncText;
    private void Awake()
    {
        _loginBase = new LoginBase();
    }

    public void LoginOnClick()
    {

        StartCoroutine(AsyncControlLogin());
    }

    public void GuestLoginOnClick()
    {
        StartCoroutine(AsyncControlGuest());
    }

    IEnumerator AsyncControlLogin()
    {
        _loginBase.SwitchEmailUsername(_email, _password);
        _asyncPanel.SetActive(true);
        _asyncText.text = "Giris yapiliyor";
        yield return new WaitUntil(() => _loginBase.LoginAsync);
        _asyncText.text = "Giris yapildi";
        yield return new WaitForSeconds(1);
        _asyncText.text = "Oyun Baslatiliyor";
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
    IEnumerator AsyncControlGuest()
    {
        _loginBase.LoginGuest(_guestLogin);
        _asyncPanel.SetActive(true);
        _asyncText.text = "Giris yapiliyor";
        yield return new WaitUntil(() => _loginBase.LoginAsync);
        _asyncText.text = "Giris yapildi";
        yield return new WaitForSeconds(1);
        _asyncText.text = "Oyun Baslatiliyor";
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
