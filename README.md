# FFVIII_LAUNCHER-Alternative
This is a drop in replacement to the FFVIII remaster launcher. It just starts the game and exits. 


This is very simple you just put this in place of your FFVIII_LAUNCHER.exe and when you run this or FFVIII the game pretty much just starts. You may see a console box. That is just this running. It exits soon as the game is launched. I had issues with a mod I was trying to run. That it was interfering with the normal FFVIII_LAUNCHER.exe. So I looked at what the real launcher does to run the game and made this.

# __Troubleshooting__

```
A program error has occurred.
error: 3889861889 : 337
can't open configuration file : 'config.txt'
```

- Mean's you don't have a valid config.txt. These steps might be overkill you could try a combination of these steps.

  1. __Uninstall any mods__
  2. __Delete your config.txt if exists from:__ `Documents\My Games\FINAL FANTASY VIII Remastered\Steam\###`
  3. __Verify Integrity of Game Files...__
  4. __Run Final Fantasy VIII Remastered _WITHOUT ANY MODS!!!___
  5. __Reinstall mods.__ _(Maybe one at a time, test after each install to be safe!)_

- You're Antivirus says this is a virus? __It's not!__ Some antivirus software works on a trust model. If it sees something new it doesn't trust it. So you have to add it to your exceptions list, or don't use this. You can see what the software does in the sourcecode...
