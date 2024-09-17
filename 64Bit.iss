; -- 64Bit.iss --
; Demonstrates installation of a program built for the x64 (a.k.a. AMD64)
; architecture.
; To successfully run this installation and the program it installs,
; you must have a "x64" edition of Windows.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=lesportif
AppVersion=1.5
WizardStyle=modern
DefaultDirName={autopf}\lesportif
DefaultGroupName=lesportif
UninstallDisplayIcon={app}\lesportif.exe
Compression=lzma2
SolidCompression=yes
OutputDir=C:\Users\hasse\source\repos\LeSportif\bin\Debug
; "ArchitecturesAllowed=x64" specifies that Setup cannot run on
; anything but x64.
ArchitecturesAllowed=x64
; "ArchitecturesInstallIn64BitMode=x64" requests that the install be
; done in "64-bit mode" on x64, meaning it should use the native
; 64-bit Program Files directory and the 64-bit view of the registry.
ArchitecturesInstallIn64BitMode=x64
  [Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "armenian"; MessagesFile: "compiler:Languages\Armenian.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"
[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
[Files]
Source: "bin\Debug\*"; DestDir: "{app}";Flags: ignoreversion recursesubdirs createallsubdirs
Source: "bin\debug\lesportif.exe"; DestDir: "{app}" ; Flags: promptifolder
Source: "bin\debug\lesportif.exe*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

;***********************************************************************************


[Icons]
Name: "{group}\My Program"; Filename: "{app}\MyProg.exe"
 [Run]
Filename: "{app}\lesportif.exe";Description: "Lancer lesportif"; Flags: nowait postinstall