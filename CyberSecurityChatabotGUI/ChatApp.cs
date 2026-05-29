using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace CyberSecurityChatabotGUI
{
    public class ChatApp
    {
        private string userInterest;
        private Dictionary<string, List<string>> keywordResponses;

        public ChatApp()
        {
            keywordResponses = new Dictionary<string, List<string>>
        {
            { "password", new List<string> { "Make sure to use strong, unique passwords for each account.", "Avoid using personal details in your passwords." } },
            { "privacy", new List<string> { "It's crucial to review your privacy settings regularly.", "Consider using a VPN for added privacy." } },
            { "phishing", new List<string> { "Be cautious of emails asking for personal information.", "Always verify the sender's email address." } }
        };
        }

        public void PlayGreeting()
        {
            using (SoundPlayer player = new SoundPlayer("C:\\Users\\lwand\\source\\repos\\CyberSecurityChatabotGUI\\CyberSecurityChatabotGUI\\WelcomVid.wav"))
            {
                player.PlaySync();
            }
        }

        public void DisplayLogo()
        {
            MessageBox.Show(@"
 ____ ___  _ ____  _____ ____    ____  _     ____ _____ ____  ____  ____ _____ 
/   _\\  \///  _ \/  __//  __\  /   _\/ \ /|/  _ Y__ __Y  _ \/  _ \/  _ Y__ __\
|  /   \  / | | //|  \  |  \/|  |  /  | |_||| / \| / \ | / \|| | //| / \| / \  
|  \__ / /  | |_\\|  /_ |    /  |  \__| | ||| |-|| | | | |-||| |_\\| \_/| | |  
\____//_/   \____/\____\\_/\_\  \____/\_/ \|\_/ \| \_/ \_/ \|\____/\____/ \_/  
                                                                                   
                                                                                                                                                                          
           ", "Logo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GetUserName()
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Please enter your name:", "User Name", "");
            while (string.IsNullOrWhiteSpace(name))
            {
                name = Microsoft.VisualBasic.Interaction.InputBox("Name cannot be empty. Please enter your name:", "User Name", "");
            }
            return name;
        }

        public void WelcomeUser(string userName)
        {
            MessageBox.Show($"\nWelcome, {userName}! I'm your friendly Cyber Security Chatbot.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(1000);
        }

        public void StartChat(string userName)
        {
            string userInput;
            do
            {
                userInput = Microsoft.VisualBasic.Interaction.InputBox("You:", "Chat Input", "");
                RespondToUser(userInput, userName);
            } while (!string.IsNullOrWhiteSpace(userInput));
        }

        public void RespondToUser(string input, string userName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Chatbot: I do not understand that, could you rephrase?", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (keywordResponses.ContainsKey(input.ToLower()))
            {
                Random rand = new Random();
                var responses = keywordResponses[input.ToLower()];
                MessageBox.Show($"Chatbot: {responses[rand.Next(responses.Count)]}", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (input.ToLower())
            {
                case "How are you":
                    MessageBox.Show("Chatbot: I'm just a program, but I'm here to help you!", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "What is your purpose":
                    MessageBox.Show("Chatbot: My purpose is to assist you with cyber security questions.", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "What can i ask you about":
                    MessageBox.Show("Chatbot: You can ask me about password safety, phishing, and safe browsing.", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Chatbot: I do not understand that, could you rephrase?", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        public void StoreUserInterest(string interest)
        {
            userInterest = interest;
            MessageBox.Show($"Chatbot: Great! I'll remember that you're interested in {interest}.", "Interest Stored", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
