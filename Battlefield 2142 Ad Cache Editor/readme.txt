IGA Ad Cache Editor
===================

Copyright 2006 Michael Farrell (micolous) <http://micolous.id.au/>
Website: http://micolous.id.au/projects/bf2142/

A big thanks to the folks at totalbf2142.com for their assistance with research and testing!

This is an ALPHA version of the software.  It may contain bugs.  Please backup your icontent.cache file before using this software.  USE THIS SOFTWARE AT YOUR OWN RISK!

This program may be a violation of the game's EULA.  Please consult the license agreement, and possibly a legal professional before using this software, if you are in doubt.

This program has been tested with the following games:

- Battlefield 2142 (retail and demo)
- Trackmania Nations

License
=======

Notice: This program references and bundles a number of libraries, which are licensed differently from this software.  See libraries.txt for a reference of their licenses.

The "IGA Common" library is part of the main program, and is licensed under the GNU General Public License.  The "DDSReader" library is released under a BSD license.

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

What's new in 0.1.5:
====================

- New abstracted database connection system, "IGADatabaseConnector".  This is a part of the "IGA Common" module.  This allows you to write non-WinForms interfaces using the same engine.
- The AdPackSupport libraries are now no longer used.  The AdPackImportForm and AdPackExportForm are now a part of the main module again, and the AdPack and AdPackEntry classes are now a part of IGACommon.  As a result, IGACommon.dll now depends on SharpZipLib.
- Localisable stubs added.
- The "vaccum/shrink database" menu item is now no longer disabled if an unsupported appId is found.
- Mono.Data.SqliteClient is used in favour of System.Data.SQLite, so to allow for cross-platform support.
- DDSReader has undergone a major overhaul, with native .NET DDS reading.  As a result, DDSReader no longer depends on DevIL or DevIL.NET.  This means that the program, uncompressed, is about 1MB smaller.
- IGACommon and DDSReader now build under Mono without issues.

Todo before 0.1.5 is released:
==============================

- Fix importing of images
- Complete DDSImage class implementation to support all major compressors.
- Improve speed of DDSImage loading into a Bitmap




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

I would also recommend that you do not delete the documentation, it is often useful!

If you try to run a component that has been removed or otherwise disabled, the program will throw an exception.  It might give you the option to continue, or it may just crash outright.  You have been warned!

Required Files (you shouldn't delete these):
 - IGA Ad Cache Editor.exe (this is the main program)
 - IGACommon.dll (contains shared functions used throughout the program)
 - System.Data.SQLite.dll (contains the SQLite implementation, which is needed to open the cache files)
 
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

