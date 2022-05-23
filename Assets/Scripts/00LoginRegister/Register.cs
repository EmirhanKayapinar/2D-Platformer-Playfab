using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{

    RegisterBase _registerBase;
    InputController _inputControl;
    [SerializeField] GameObject _asyncPanel,_registerPanel,_loginPanel;
    [SerializeField] Text _asyncText;
    [SerializeField] InputField _email, _password, _username,_repeatPassword;
    [SerializeField] Button _registerButton;
    SetDefaultAvatar _setAvatar;

    private void Awake()
    {
        _registerBase = new RegisterBase();
        _inputControl = new InputController();
        _setAvatar = new SetDefaultAvatar();
    }

    public void RegisterOnClick()
    {
        StartCoroutine(AsyncControl());
    }

    IEnumerator AsyncControl()
    {
        _registerBase.RegisterOnClick(_email.text, _password.text, _username.text);
        _asyncText.text = "Kayit olusturuluyor";
        yield return new WaitUntil(() => _registerBase.Register_Async);
        _asyncPanel.SetActive(true);
        _asyncText.text = "Kayit basariyla olusturuldu olusturuldu";
        SetDefaultAvatar();
        yield return new WaitForSeconds(1);
        _asyncText.text = "Login ekrani aciliyor";
        yield return new WaitForSeconds(1);
        _asyncPanel.SetActive(false);
        _registerPanel.SetActive(false);
        _loginPanel.SetActive(true);
    }

   
    public void RegisterInputControl()
    {
        _inputControl.RegisterInputController(_email, _password, _repeatPassword,_username, _registerButton);
    }

    public void SetDefaultAvatar()
    {
        _setAvatar.SetDefaultAvatarImage("https://www.gravatar.com/userimage/221184320/33280c8e064d8b98c7a52823bff77d41?size=120");
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
