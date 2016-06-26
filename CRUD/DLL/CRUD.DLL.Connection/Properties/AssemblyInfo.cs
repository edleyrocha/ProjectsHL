#region Copyright and License Information
/**
 * 
 *           <git hub="https://github.com/edleyrocha"> 
 *               GitHub Repositories
 *           </git>
 *            <mail address="contato@hoyler.com.br">
 *                Developer Email                    
 *            </mail>
 *            <copyright company="HOYLER Tecnologia">
 *                Copyright (c) HOYLER Tecnologia. All rights reserved.
 *            </copyright>
 *
**/
#endregion
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("HOYLER.Connection")]
//[assembly: AssemblyDescription("SQLite Connection")]
//[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("HOYLER Tecnologia")]
[assembly: AssemblyProduct("HOYLER.Connection.dll")]
[assembly: AssemblyCopyright("Copyright © 2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(false)]

#if (DEBUG)

[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyDescription("Modo = Debug SQLite Connection")]

#else

[assembly: AssemblyConfiguration("Retail")]
[assembly: AssemblyDescription("Modo = Release SQLite Connection")]

#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access A type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the DBBackupServer_ID of the typelib if this project is exposed to COM
[assembly: Guid("a032fcaf-c862-46a1-84ec-a419f6992bd0")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.1")]
[assembly: AssemblyFileVersion("1.0.0.1")]
[assembly: AssemblyInformationalVersion("1.0.0.1")]
