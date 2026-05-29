namespace CyberSecurityChatabotGUI
{

    public partial class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ChatApp chatApp = new ChatApp();
            chatApp.PlayGreeting();
            chatApp.DisplayLogo();
            string userName = chatApp.GetUserName();
            chatApp.WelcomeUser(userName);
            chatApp.StartChat(userName);
        }
    }
}