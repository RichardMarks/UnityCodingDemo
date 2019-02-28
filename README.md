# UnityCodingDemo
A small demonstration of my ability to use Unity to develop games.

![https://github.com/RichardMarks/UnityCodingDemo/raw/wiki/wiki/ucd.png](https://github.com/RichardMarks/UnityCodingDemo/raw/wiki/wiki/ucd.png)

## What is this?

A small playable game demo (you can get a score from killing enemies, and you restart when you die) built in roughly 11 hours.

## Features

+ Modular architecture (mostly the single responsibility principle)
+ 2D Radar implementation using Render Texture and secondary Camera and Layer to create a custom view of the game world.
+ Sound Effects & Looping Background Music
+ Player Controls: Arrow Keys, WSAD, Space, Gamepad Left Stick, "A" XBOX 360 controller button
+ Crude enemy "AI" using bounds checking and a box collider to fake line of sight
+ "Layout" concept used to create a bounded game world with camera follow (scrolling) and destroy outside layout, etc...
+ Animated explosion sprite + animation events to trigger collision check and destruction of explosion object
+ Custom Class and Custom Property Drawer to show example of a Unity Editor extension

## Notes:

The Level2 Scene is what should be loaded, Unity refused to save over Level for some reason. 
The Unity Player Settings still references the Level scene, and needs to be updated to Level2 before a build.

## Resources

+ Uses graphics and some game design concepts from https://www.construct.net/en/tutorials/beginners-guide-to-construct-3-1
+ Uses Font from https://www.kenney.nl/assets/kenney-fonts
+ Music and SFX created by Richard Marks
+ All C# Scripts created by Richard Marks
+ Custom Additive blending sprite shader is a modification of the built-in sprites-default shader

## Thanks

Thanks to Brackeys youtube channel for answering some of the questions I had while figuring out the Radar system.

## LICENSE

I hereby license all the code I've written here under the MIT License.
All resources that are not mine, are licensed under their respective licenses.
