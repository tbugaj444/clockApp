# clockApp
## Installation
* [Download] First step is to download the project from GitHub
* [Pick your Device] If your using an Android phone, now is the time to plug it into your computer. Be sure that developer options 
are turned on and you have your settings set up so taht you can view your devices files in your local File explorer.
(You can google how to do this, it can vary for each device)
** If you are using an emulator be sure that it is pulled up on the screen somewhere.
* [APK] Find the [clockApp.apk] in the project folder.
* [Drag and Drop] the file into your device internal storage drive(be sure it is in your main drive). 
If your using an emulator, you can just drag and drop 
the APK into the home screen of the emulated device. Your emulator should install the app for you at this point.
* [Go Find the File] in your device's file viewer. Click on it and accept the Install.
### ALL DONE!
## Purpose
This app is apart of my Intro to Software Engineering class at Wright State University. This App is for phones that run Android OS, 
however since the project was built in Unity, an IOS version could be easily obtained.
The Primary focus of this project was to implement a design pattern, and create an application capable of displaying the time in 2 
different formats. The user should be able to add as many clocks as he/she wants in a single view. Also the user must be able to 
Change the time and date, and this manipulated time must be diplayed across all the clocks in the users ClockView.
## Design
The project requiremnet was to build into the command design pattern. This mkaes the most sense, seeing most changes being made to 
the view is done by the user. The model controller 'TimeScript' is what is used to send information to the clocks. Primarily the information includes what unit of time that the user wishes to modify. The 2 types of clocks i created, analog and digital, use this information to update the time in their respective views in a simple update method. This view Controller is also integrated with the Scrollview, where new instances of clocks are handled and placed in the list of existing clocks. The Controler is handled in another class that manipulates the textfields in which the time measurements are read from. 
## How To Use ClockApp
After installing and opening ClockApp, the home page takes you straight to the main Scene where a analog clock is already present, displaying the current time. The six text fields in the middle of the screen provide the user to change the values. i opted to use read only textfields to reduce excpetion handling. the buttons attached are the tools used to either increment, or decrement the values. the bottom of the screen provides the user with the two options to add either a analog, or digital clock. The clocks are all displayed in te top-middle portion of the screen in the order that they were added by the user.
