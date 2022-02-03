using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace SchedulingApplication_RevA
{
    public partial class LoginPage : Form
    {

        string user;
        string passwd;

        List<string> userInfo = new List<string>();

        //Lambda expression: Used in the current class to provide a cleaner code and intuitive method approach for both of the below delegates
        Action fail = () => { MessageBox.Show("The username and password did not match."); };
        Action welcome = () => { MessageBox.Show("Welcome to CC Scheduler."); };
        public LoginPage()
        {
            InitializeComponent();
            passBox.UseSystemPasswordChar = true;
            ChangeLanguage();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            user = userBox.Text;
            passwd = passBox.Text;

            try
            {
                if(UserInfo.UserLogin(user, passwd) != null)
                {
                    string test = user;
                    UserInfo.LoggedIn(user);
                    welcome();
                    this.Hide();
                    Hub hub = new Hub(test);
                    hub.ShowDialog();
                    this.Close();
                }
                
                else
                {
                    
                    fail();
                    UserInfo.FailedLogin(user);
                    return;
                }
            }
            catch
            {
                //Exception control
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        public void ChangeLanguage()
        {
            string c = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            
            switch (c.ToUpper().ToString())
            {
                case "EN": //english
                    loginGPBox.Text = "Login";
                    userNameLbl.Text = "Username";
                    passLbl.Text = "Password";
                    break;
                case "ES": //spanish
                    loginGPBox.Text = "Acceso";
                    userNameLbl.Text = "Nombre de Usuario";
                    passLbl.Text = "Contraseña";
                    loginButton.Text = "Acceso";
                    exitButton.Text = "Salida";
                    
                    fail = () => { MessageBox.Show("El nombre de usario y la contrasena no coinciden."); };
                    welcome = () => { MessageBox.Show("Bienvenida a esta aplicacion - CC Scheduler."); };
                    break;
                case "FR": //french
                    loginGPBox.Text = "Connexion";
                    userNameLbl.Text = "Nom d'utilisateur";
                    passLbl.Text = "Mot de passe";
                    loginButton.Text = "Connexion";
                    exitButton.Text = "Sortir";

                    fail = () => { MessageBox.Show("Le nom d'utilisateur et le mot de passe ne correspondent pas."); };
                    welcome = () => { MessageBox.Show("Bienvenue dans cette application - CC Scheduler"); };
                    break;
                case "DE": //german
                    loginGPBox.Text = "Anmeldung";
                    userNameLbl.Text = "Nutzername";
                    passLbl.Text = "Passwort";
                    loginButton.Text = "Anmeldung";
                    exitButton.Text = "Ausfahrt";

                    fail = () => { MessageBox.Show("Benutzername und Password stimmen nicht uberein."); };
                    welcome = () => { MessageBox.Show("Willkommen bei dieser Anwendung - CC Scheduler"); };
                    break;
                default:
                    loginGPBox.Text = "Login";
                    userNameLbl.Text = "Username";
                    passLbl.Text = "Password";
                    break;
            }
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            CreateUserForm sendIt = new CreateUserForm();
            sendIt.ShowDialog();
        }
    }
}
