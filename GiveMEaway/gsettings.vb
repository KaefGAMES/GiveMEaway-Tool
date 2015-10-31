Imports System.IO
Public Class gsettings
    '                               __
    '                             .d$$b		          _..::::::.._
    '                           .' TO$;\		    .::::::::::::::.
    '                          /  : TP._;		   ::::::::::::::::::
    '                         / _.;  :Tb|		  ::::::::::::::::::::
    '                        /   /   ;j$j		 ::::::::::::::::::::::
    '                    _.-"       d$$$$		 ::::::::::::::::::::::
    '                  .' ..       d$$$$;		  ::::::::::::::::::::
    '                 /  /P'      d$$$$P. |\	   ::::::::::::::::::
    '                /   "      .d$$$P' |\^"l	    '::::::::::::::'
    '              .'           `T$P^"""""  :	      ''''''''''''
    '          ._.'      _.'                ;
    '       `-.-".-'-' ._.       _.-"    .-"
    '     `.-" _____  ._              .-"
    '    -(.g$$$$$$$b.              .'
    '      ""^^T$$$P^)            .(:		KaefGAMES Entertainment
    '        _/  -"  /.'         /:/;	    GiveMEAway-Tool zum organisierten Vergeben von Keys bei Livestreams :3
    '     ._.'-'`-'  ")/         /;/;       www.kaefgames.de
    '  `-.-"..--""   " /         /  ;
    ' .-" ..--""        -'          :
    ' ..--""--.-"         (\      .-(\
    '   ..--""              `-\(\/;`
    '     _.                      :
    '                             ;`-
    '                            :\
    '                            ;	 Copyright 2015, All Rights reserved
    '
    '
    '
    Dim File = Application.StartupPath + "\away.ini"
    '
    ' Bestimmt die Sektionen in der .ini
    '
    Dim Section_lang = "Language"
    Dim Section_host = "Host"
    Dim Section_sounds = "Sounds"
    '
    ' Bestimmt die "Unterpunkte" in der .ini
    '
    Dim lang = "lang"
    Dim chost = "channel_host"
    Dim psounds = "play_sounds"
    '
    '
    '
    Private Sub gsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Liest die Ini /// Unterpunkte beachten
        '
        '
        ' 1) Sprache auslesen
        '
        Dim readINI_deDE = ReadIni(File, Section_lang, lang, "deDE")
        Dim readINI_enUS = ReadIni(File, Section_lang, lang, "enUS")
        '
        '
        '
        If readINI_deDE = "deDE" Then
            langDE.Checked = True
            langEN.Enabled = False
        End If
        If readINI_deDE = "enUS" Then
            langEN.Checked = True
            langDE.Enabled = False
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        '
        ' Suggeriert, dass alles gespeichert wird ;D...Wird es aber schon vorher...MUHAHA!
        '
        Me.Close()
    End Sub

    Private Sub langDE_CheckedChanged(sender As Object, e As EventArgs) Handles langDE.CheckedChanged
        If langDE.Checked = True Then
            langEN.Enabled = False
            '
            ' Schreibt die Ini
            '
            writeIni(File, Section_lang, lang, "deDE")
        End If
        If langDE.Checked = False Then
            langEN.Enabled = True
        End If
    End Sub

    Private Sub langEN_CheckedChanged(sender As Object, e As EventArgs) Handles langEN.CheckedChanged
        If langEN.Checked = True Then
            langDE.Enabled = False
            '
            ' Schreibt die Ini
            '
            writeIni(File, Section_lang, lang, "enUS")
        End If
        If langEN.Checked = False Then
            langDE.Enabled = True
        End If
    End Sub
End Class