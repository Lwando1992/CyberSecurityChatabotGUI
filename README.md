# CybebeSecurityChataBot
The Cyber Security Chatbot application is designed to assist users with inquiries related to cyber security. The application is structured in C# and utilizes Windows Forms for its graphical user interface. Below is a breakdown of its components and functionality.

## Code Structure
### ChatApp.cs
This is the core class that manages user interactions. It initializes a dictionary of keyword responses related to cyber security topics such as passwords, privacy, and phishing. The class includes methods for greeting the user, displaying a logo, collecting the user's name, and responding to user queries.

### Program.cs
This serves as the entry point of the application. It initializes the application, plays a greeting sound, displays the logo, prompts for the user's name, and starts the chat session.

### Form1.cs
This class defines the user interface, including a text box for user input, a button to send messages, and a list box to display chat history. The SendButton_Click method captures user input and adds it to the chat history.

### Form1.Designer.cs: 
This file contains the auto-generated code for the form's layout and controls.

## Functionality
Upon launching, the application plays a greeting sound and displays a logo.
The user is prompted to enter their name, which is then used to personalize interactions.
The chatbot responds to specific keywords with pre-defined messages, while also handling general inquiries about its purpose and capabilities.

## Setup Steps
### Environment Setup 
Ensure that you have Visual Studio installed with the .NET desktop development workload.

### Create a New Project
Open Visual Studio, create a new Windows Forms App (.NET Framework) project, and name it appropriately.
### Add Code
Copy the provided code into the respective files (ChatApp.cs, Program.cs, Form1.cs, and Form1.Designer.cs).
### Add Sound File
Place the WelcomVid.wav sound file in the specified directory or update the path in the PlayGreeting method accordingly.
### Build and Run
Compile the project and run it. The application should launch, allowing user interaction with the chatbot.

This application serves as an engaging tool for educating users about cyber security best practices while providing a user-friendly interface.
