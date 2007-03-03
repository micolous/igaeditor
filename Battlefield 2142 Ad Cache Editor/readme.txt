IGA Ad Cache Editor
===================

Version 0.1.6

Copyright 2006 - 2007 Michael Farrell (micolous) <http://micolous.id.au/>
Website: http://igaeditor.sourceforge.net/

A big thanks to the folks at totalbf2142.com for their assistance with research and testing!

This is an BETA version of the software.  It may contain bugs.  Please backup your icontent.cache file before using this software.  USE THIS SOFTWARE AT YOUR OWN RISK!

This program may be a violation of the game's EULA.  Please consult the license agreement, and possibly a legal professional before using this software, if you are in doubt.

This program has been tested with the following games:

- Battlefield 2142 (retail and demo)
- Trackmania Nations

License
=======

Notice: This program references and bundles a number of libraries, which are licensed differently from this software.  See libraries.txt for a reference of their licenses.

The "IGA Common" library is part of the main program, and is licensed under the GNU General Public License.  The "DDSReader" library is released under the LGPL.

See 'gpl.txt' for a full copy of the GNU General Public License.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

What's new in 0.1.6:
====================

- Modified DDSReader so that it would use "unsafe" code to do it's work much faster on Windows (and Microsoft's .NET CLR), due to some severe performance issues with Microsoft's version of .NET.
- New "thumbnails" view, so you can see all the ads at once.  Press the "Switch View" button on the menu bar to switch between thumbnails view and details view.  If there is demand, this may become the default view in future.
- Fixed some problems with case sensitivity errors with the property 'zoneId'.  It has been accientally used as 'zoneid' in many areas in the past.  They have all been corrected.  If records made by old versions of the software are causing the program to crash after editing a record, you will need to delete the record and recreate it.
- Records that are orphans (that is, they have no entry in the 'contentlist' table), are now marked and repairable.  This will fix issues that you may have had where orphaned records (either orphaned by IGA's software or by a bug in earlier versions of the software where new records wouldn't show up).  There's also a new "Orphan" property in ContentEntry so that they can be detected.  There's also a new function in IGADatabaseConnector to allow you to repair them.
- The main view's context menu can be triggered by pressing either Enter while an entry is selected.

What I'd like to have in later versions
=======================================

- More application support, if other applications can be found that use IGA's software.

What is this app?
=================

This application imports and exports DDS image files from the ad cache of Battlefield 2142.  You can also import and export groups/sets of images (adpacks).

It does not block access to the database.

What do I need?
===============

- Microsoft .NET Runtime 2.0 (or compatible version of Mono).

SQLite (for Windows) and SharpZipLib have been bundled with this software.  Future versions of Mono may be able to run this, once they have a more complete System.Windows.Forms implementation.  On non-Windows systems, you will need the native SQLite libraries for your OS installed.

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
- In the Save DDS options dialogue, select "DXT1" (or "DXT3") compression and "Generate Mipmaps".

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

In your "My Documents" folder, under "Battlefield 2142" or "Battlefield 2142 Demo".  Remember to back it up before changing it.  Some other games put it elsewhere, try looking in:

- The game's program directory
- The game's Application Data directory (in your profile)
- The game's Local Settings directory (in your profile)

Otherwise use the Windows search function to find it, or some other app that searches your hard disk, for the 'icontent.cache' file.

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

Why does it take so long to preview images on Windows?
======================================================

There's probably a performance issue with Microsoft's version of the .NET environment.  It runs at normal speeds in Mono on Linux.  Trying to work around it will be "interesting", to say the least.  It is to do with the way I extract raw image data and convert it to a Bitmap object internally.

This program is very big... I don't need all these features!
============================================================

The program is slightly modular, you can chop out bits that you don't need.  You shouldn't redistribute versions that are cut down, but the only legal requirement is that you keep the applicable licensing information intact.

I would also recommend that you do not delete the documentation, it is often useful!

If you try to run a component that has been removed or otherwise disabled, the program will throw an exception.  It might give you the option to continue, or it may just crash outright.  You have been warned!

Required Files (you shouldn't delete these):
 - IGA Ad Cache Editor.exe (this is the main program)
 - IGACommon.dll (contains shared functions used throughout the program)
 - System.Data.SQLite.dll (contains the SQLite implementation, which is needed to open the cache files)

Windows SQLite Library:
 - sqlite3.dll (You only need this if you are running the software in Windows).
 
Adpack support: (you will not be able to import/export adpacks if you remove these)
 - ICSharpCode.SharpZipLib.dll (ZIP compression library)

Development Documentation Files (these are only needed if you are writing a program based on or that references this program):
 - All XML files. (*.xml)

Debugging Symbols (if the program crashes, you should restore these before fileing a bug report):
 - All PDB files. (*.pdb)
 
Thumbnail Support: (if you remove these, you will not be able to view thumbnails)
 - DDSReader.dll (This is referenced to open DDS images)
 - DDSReader.pdb (These are the debugging symbols for the library)
 - DDSReader.xml (This is the development documentation for the library)

I found a bug, how do I report it?
==================================

Email micolous -at- gmail -dot- com.  Include a copy of your icontent.cache file (please use 7zip or ZIP format to compress it first), and a description of the symptoms.

