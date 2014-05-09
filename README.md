Caliburn WP8 Template
=====================

Visual Studio template for Windows Phone 8 apps using Caliburn.Micro.

Installing This Template
===================

To use this template with Visual Studio (I used 2013, 2012 should work too):
* Goto the File menu > Export Template
* Choose Project Template
* Choose the Template project
* Hit the Next button
* Change the template name to something more obvious like CaliburnWP8
* If you choose to automatically import it into visual studio,, you are done here. It will put it under the Visual C# selector in the new project selector.
* If you want to put it into a specific place (like say with the rest of the Windows Phone templates) you should move the zip file into the Visual Studio projects Templates folder, under a new folder called Windows Phone. For example, mine is %USERPROFILE%\My Documents\Visual Studio 2013\Templates\ProjectTemplates\Visual C#\Windows Phone


Using This Template
===================

This template is pretty barebones. It starts with Caliburn 1.5.2 installed, a Main view and viewmodel, a boolean/visibility converter, a resource file and resource dictionary entry for using this in XAML, and a custom convention to make LongListSelectors work. It builds and runs and does absolutely nothing by default.

I find it handy because it is the least amount of boilerplate I need to get a new Caliburn project set up.
