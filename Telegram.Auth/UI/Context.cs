using System.Drawing;
using System.Runtime.CompilerServices;
using TelegramClient.Auth.Auth;
using TelegramClient.Auth.Domain;
using TelegramClient.Auth.Service;


namespace TelegramClient.Auth.UI;

public class Context
{
 
    private LoginUI _loginUi;
    private RegistraionUI _registraionUi;
    private ViewBase _viewBase;
    public ViewBase Activeview { get; set; }
    public User User { get; set; }

    public Context(Point topPoint,Point bottomPoint )
    {
        _loginUi = new LoginUI(this,topPoint,bottomPoint);
        _registraionUi = new RegistraionUI(topPoint,bottomPoint);
        Activeview = _loginUi;
    }

    public  void Start()
    {
        Activeview.Home();

    }

    public void ShowRegistration() => this.Activeview = this._registraionUi;
    public void ShowLogin() => this.Activeview = this._loginUi;
}