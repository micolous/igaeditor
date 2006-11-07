IGA Ad Cache Editor
===================

Copyright 2006 Michael Farrell (micolous) <http://micolous.id.au/>
Website: http://micolous.id.au/projects/bf2142/

A big thanks to the folks at totalbf2142.com for their assistance with research and testing!

This is an ALPHA version of the software.  It may contain bugs.  Please backup your icontent.cache file before using this software.  USE THIS SOFTWARE AT YOUR OWN RISK: THE AUTHOR GIVES NO WARRANTIES.

This program may be a violation of the game's EULA.  Please consult the license agreement, and possibly a legal professional before using this software, if you are in doubt.

This program has been tested with the following games:

- Battlefield 2142 (retail and demo)
- Trackmania Nations

Notice: This program references and bundles a number of libraries, which are licensed differently from this software.  See libraries.txt for a reference of their licenses.

What's new in 0.1.4:
====================

 - The application is now called "IGA Ad Cache Editor".
 - The application has had a license change, and is now licensed under the terms of the GNU General Public License 2.0 as published by the Free Software Foundation.  This applies to everything not covered explicitly by another license (ie: the main program code).
 - Some parts of the program have been seperated into "subproject libraries", so that you can pick and choose which components you wish to use.  This process is incomplete - a new database layer is coming!  This will eventually allow you to use another interface other than Windows Forms, meaning it'll work around Mono's incomplete SWF support.  Once the database layer is seperated, this opens up all sorts of development possibilities that use the file format.
 - A new "Debug" menu with debugging and testing functionality has been added.
 - A bug where a missing "appid" field would lock you out of the database has now been fixed.
 - You can now change the "appid" of the cache to pretend to be for another application.
 - There is a simple SQL "injector/executor" window, which means that debugging queries no longer need a stand-alone program to execute queries.
 - Date and Time formats now follow the system locale settings.  In Windows, this is set in the "Regional and Language Options" control panel.
 - There is an image preview function, that allows you to view DDS images without exporting them.
 - Some UI elements have been adjusted.
 - Licensing used in different parts of the program has been made clearer (libraries.txt).
 - There are the starts of some development hooks, allowing you to write applications that use parts of the cache editor as a library.  Bear in mind that the GPL License requires that code that links to this program or it's libraries is licensed under a GPL-compatible license as well (which means you need to provide source code, if you are releasing it).

What is this app?
=================

This application imports and exports DDS image files from the ad cache of Battlefield 2142.  You can also import and export groups/sets of images (adpacks).

It does not block access to the database.

What do I need?
===============

- Microsoft .NET Runtime 2.0 (or compatible version of Mono).

System.Data.SQLite and SharpZipLib have been bundled with this software.

How do I view/edit DDS images?  Why can't you use a standard format?
====================================================================

DDS *is* a standard format used by DirectX games.  If you want to minipulate the files, you have options:

- The GIMP DDS Plugin: http://registry.gimp.org/plugin?id=4816
- Adobe Photoshop DDS Plugin (by NVidia): http://developer.nvidia.com/object/photoshop_dds_plugins.html
- Windows Explorer DDS Thumbnail Plugin (by NVidia): http://developer.nvidia.com/object/dds_thumbnail_viewer.html

There are some other tools linked here: http://cs.elderscrolls.com/constwiki/index.php/DDS_Tools

In The GIMP, to output in the correct format:

- Ensure you're using 24-bit colour (RGB) mode.
- The image is flattened (no layers)
- In the Save DDS options dialogue, select "DXT1" compression and "Generate Mipmaps".

Why doesn't this app automatically convert for you?
===================================================

I've tried three different libraries claiming to be able to nicely convert the image.  All of them REQUIRED that the image be in a file, and outputted to a file.  So this isn't an option at this time.

Other libraries don't work with .NET 2.0, or require ugly wrappers for architecture-dependant code.

How do I stop BF2142 from downloading ads?
==========================================

You will need to block the BF2142 advertising servers using your firewall.  It is recommended you "REJECT" connections rather than "DROP" them, that way it won't take as long to load the game.

The subnets you need to block are:

72.3.184.144/28
72.32.5.0/28

Some people have reported that denying write access to the cache file to your user will also prevent it, however this may cause internal problems with BF2142.

If you do not block the ad servers, or otherwise attempt to protect your cache file, ads will continue to be downloaded to your computer.

Where is icontent.cache?
========================

In your "My Documents" folder, under "Battlefield 2142" or "Battlefield 2142 Demo".  Remember to back it up before changing it.

What is the format of the icontent.cache file?
==============================================

It is an sqlite3 database.  The fields are fairly self-explanitory.

What is the format of the .adpack files?
========================================

They are ZIP files.  Export one and you'll see the format.  "metadata.dat" and "fileinfo.dat" are text files.  ; is used at the end of a variable, and = is used to seperate the variable and the key.  In fileinfo.dat, newlines are used to seperate records.  

The contentType field is identical to what the game uses, so it is fairly extensible.

Start is:
	- 128x256: 202
	- 128x128: 204
	- 512x256: 208
	- 512x128: 210
	- 256x512: 302
	- 256x256: 304
	- 512x64: 411
Ending part is:
	- BIK Video: 1000
	- DDS Image: 1100
	
These are the known formats so far.

How do I make it so I can double-click a .adpack file in Explorer and import it?
================================================================================

Associate this app with it (manually), and then it will work.  I'd need to write an installer to make it automatic, which I don't want to do (keeping it simple!).

My cache file is still big, even though I've deleted old images from it.
========================================================================

Select "Vaccum/Shrink Database" from the "Application" menu.

This program is very big... I don't need all these features!
============================================================

The program is slightly modular, you can chop out bits that you don't need.  You shouldn't redistribute versions that are cut down, but the only legal requirement is that you keep the applicable licensing information intact.

I plan to make the program more modular in the future.  IGACommon may in the future also start containing the database code, which will allow you to write your own frontends (eg: GTK#) without needing to decipher the file format.

I would also recommend that you do not delete the documentation, it is often useful!

If you try to run a component that has been removed or otherwise disabled, the program will throw an exception.  It might give you the option to continue, or it may just crash outright.  You have been warned!

Required Files (you shouldn't delete these):
 - IGA Ad Cache Editor.exe (this is the main program)
 - IGACommon.dll (contains shared functions used throughout the program)
 - System.Data.SQLite.dll (contains the SQLite implementation, which is needed to open the cache files)

Development Documentation Files (these are only needed if you are writing a program based on or that references this program):
 - All XML files. (*.xml)

Debugging Symbols (if the program crashes, you should restore these before fileing a bug report):
 - All PDB files. (*.pdb)
 
Adpack Support:
 - AdPackSupport.dll (This is referenced to import and export adpack files)
 - AdPackSupport.pdb (These are the debugging symbols for the library)
 - AdPackSupport.xml (This is the development documentation for the library)
 - ICSharpCode.SharpZipLib.dll (This is the ZIP library used to compress and decompress adpack files)

Thumbnail Support:
 - DDSReader.dll (This is referenced to open DDS images)
 - DDSReader.pdb (These are the debugging symbols for the library)
 - DDSReader.xml (This is the development documentation for the library)
 - DevIL.NET.dll (This is the .NET wrapper for DevIL)
 - DevIL.dll (This is the DevIL itself. (teehee))
 - ILU.dll (This is a support library used by DevIL)

I found a bug, how do I report it?
==================================

Email micolous -at- gmail -dot- com.  Include a copy of your icontent.cache file (please use 7zip or ZIP format to compress it first), and a description of the symptoms.

