# IMClient
C# implementation of an instant message client
INTRODUCTION
The goal of this application is to provide the ability for two users to communicate over an internal-network connection, on the same access point. 

Requirements
1. User shall have the ability to select a username via GUI interface.
2. User must have the ability to receive messages at all times during runtime.
3. User shall have the ability to send messages back and forth through a TCP connection.


Design
Feature
Description
Method
Username
Ability to add a username
Pop-up window from app
Receive messages
Ability to receive a message from other client
Several thread launched at runtime
Send messages
User sends a message string over an TCP connection
Button event handler
Display messages
Tied to send messages, the message is displayed to both the client and intended other user to the chat window
Thread from connection / Button event handler



Diagram



Notes
In the current build, the application sends the message on a loopback address with an annotated message “FROM SERVER”, with the message that the receive-message function picked up from the loopback address “127.0.0.1”. 
This application is multithreaded - with both the main application thread and the receive-messages thread running simultaneously. In order for two threads to communicate with the same physical object on a windows form application (a text label, for instance), we must introduce a way to resolve the critical-section problem, such that the object is reacting exactly the way we want it to. In order to resolve this, and for debugging purposes, the check for illegal thread calls feature in Visual Studio has been turned off. While this is not optimal for a final release, it allows for exploration of debugging. A mutual space for the two threads to communicate safely shall be introduced in the next iteration.  
