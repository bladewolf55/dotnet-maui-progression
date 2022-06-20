---  
Title          : .NET MAUI Progression 01 - From Basics to ViewModel  
PublishedOn    : 2022-06-20 07:51:00  
Slug           : _net_maui_progression_01_-_from_basics_to_viewmodel
Tags           :  
Status         : Draft  
---

## The Series


## The Problem .NET MAUI Solves


## (Brief) Getting Started: The Default App
The instructions assume running in Windows 10/11. You can follow the instructions below, which are brief and aren't intended as a beginner's guide. Or, use [Microsoft's official documents](https://docs.microsoft.com/en-us/dotnet/maui/get-started/first-app?pivots=devices-android).

### The Project

1.  Install and open Visual Studio 2022 Preview
1.  Create a new project
    ![](2022-06-20-07-55-35.png)
1.  Filter for C# MAUI, or search for ".NET MAUI App"
    ![](2022-06-20-07-58-25.png)
1. Create a .NET MAUI App using the defaults. Change the name to match mine if you want.

### The Android Emulator

> **Important**  
> You'll need to [enable either Hyper-V or HAXM](https://docs.microsoft.com/en-us/dotnet/maui/android/emulator/hardware-acceleration). 

> **Note**  
> I had trouble with Hyper-V on my laptop even though it's supported and had to use HAXM for a while. The problem went away when I did a clean install of Windows 11. Presumably, that would have been true in Windows 10.

1.  Choose Debug Target > Android Emulator
    ![](2022-06-20-08-07-30.png)
1.  Click to start the emulator. The Android Device Manager starts. Answer Yes to allow changes.
1.  You *can* accept the default Pixel 5 Android 12.0 (Level 31). However, I recommend canceling at this point and manually creating a Pixel 5 Android 12.1 (Level 32) or later. There are some behavior differences worth seeing, specifically in how the splash screen is treated.
    ![](2022-06-20-08-15-46.png)  
    ![](2022-06-20-08-16-17.png)  
1.  You don't need to explicitly start the emulator. Running the app will do that. So . . .
1.  Run the app!  
    ![](2022-06-20-08-17-43.png)

This should start the emulator, then install and run the default app. On my machine, this takes a couple of minutes.

![](2022-06-20-08-22-10.png)

Clicking the button increases a counter.

> **Warning**  
> Amazingly, as of 2022-06-20, using Android 12.1 as configured above, clicking the button doesn't display the number of clicks because of the padding. To fix this:
> 1.  Open `Mainpage.xaml`
> 1.  Change VerticalStackLayout Padding to "0,0".  
>     ```xml
>     <VerticalStackLayout 
>         Spacing="25" 
>         Padding="0,0" 
>     ```

## MVVM Basics
Great, we have a working app! And the .NET MAUI team have included lots of boilerplate to understand. But one thing not included is implementing the Model-View-ViewModel MVVM pattern.

We need to separate our code to improve maintenance and testing (more on testing in a later post!). One pattern for doing this is MVVM. Similar to Model-View-Controller (MVC), MVVM says, 

1.  The Model contains our raw domain information and business behaviors, which may come from various data sources. (See Domain-Driven Design.)
1.  The ViewModel typically retrieves the Model via a service. The ViewModel then prepares the information for display.
1.  The View displays whatever's in the ViewModel.

The *separation of concerns* here is that

1.  The View doesn't know how the ViewModel gets its information.
1.  The ViewModel doesn't know how the Model gets its information.

This allows us to make changes to the View, ViewModel, and Model mostly independently. We strive for *loose coupling*.

An important aspect of MVVM is how to bind the View to the ViewModel. The user interacts with the View, for example clicking a button to increment a counter. This updates the data stored in the ViewModel (and possibly gets passed to the Model).

However, we can also update the values programmatically directly in the ViewModel, and we want those values to display in the View. This is two-way binding.

There'll be more about binding later, but for an excellent tutorial of binding--in fact, of .NET MAUI in general--you should really go through [James Montemagno's Workshop](https://www.youtube.com/watch?app=desktop&v=DuNLR_NJv8U)


## Creating the ViewModel
Right now, when we click the app's button it runs code in the `MainPage.xaml.cs` class. If this looks familiar to some of you[^ancient], it's because it's the same code-behind approach used in ASP.NET WebForms.

[^ancient]: The ancient ones


