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
    Dim Web As New Net.WebClient()
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
    Dim ckey = "channel_key"
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
        Dim readLANG = ReadIni(File, Section_lang, lang, "")
        '
        ' 2) Übersetzungen anwenden
        ' 
        If readLANG = "deDE" Then
            langDE.Checked = True
            langEN.Checked = False
            save.Text = "Speichern"
            ' Übersetzungen // TAB ALLGEMEIN
            Label1.Text = "Wähle eine Sprache"
            TabPage1.Text = "Allgemein"
            TabPage2.Text = "Anbieter"
            langDE.Text = "Deutsch"
            langEN.Text = "Englisch"
            '
            Label2.Text = "Sound Einstellungen"
            playsyes.Text = "Sounds abspielen"
            playsno.Text = "Keine Sounds abspielen"
            ' Übersetzungen // ANBIETER
            CONNECThitbox.Text = "Verbinden"
            CONNECTtwitch.Text = "Verbinden"
        End If
        If readLANG = "enUS" Then
            langEN.Checked = True
            langDE.Checked = False
            save.Text = "Save"
            ' Translations // TAB GENERAL
            Label1.Text = "Choose a Language"
            TabPage1.Text = "General"
            TabPage2.Text = "Host"
            langDE.Text = "German"
            langEN.Text = "English"
            '
            Label2.Text = "Sound Settings"
            playsyes.Text = "Play Sounds"
            playsno.Text = "Don't play Sounds"
            ' Translations // HOST
            CONNECThitbox.Text = "Connect"
            CONNECTtwitch.Text = "Connect"
        End If
        '
        ' Lese Sound-Einstellungen
        '
        Dim readSOUND = ReadIni(File, Section_sounds, psounds, "")
        ' Wenn aktiviert
        If readSOUND = "1" Then
            playsyes.Checked = True
            playsno.Checked = False
        End If
        ' Wenn deaktiviert
        If readSOUND = "0" Then
            playsyes.Checked = False
            playsno.Checked = True
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        '
        ' Suggeriert, dass alles gespeichert wird ;D...Wird es aber schon vorher...MUHAHA!
        '
        gaway.Show()
        Me.Close()
    End Sub

    Private Sub langDE_CheckedChanged(sender As Object, e As EventArgs) Handles langDE.CheckedChanged
        If langDE.Checked = True Then
            langEN.Checked = False
            '
            ' Schreibt die Ini
            '
            writeIni(File, Section_lang, lang, "deDE")
        End If
        If langDE.Checked = False Then
            langEN.Checked = True
        End If
    End Sub

    Private Sub langEN_CheckedChanged(sender As Object, e As EventArgs) Handles langEN.CheckedChanged
        If langEN.Checked = True Then
            langDE.Checked = False
            '
            ' Schreibt die Ini
            '
            writeIni(File, Section_lang, lang, "enUS")
        End If
        If langEN.Checked = False Then
            langDE.Checked = True
        End If
    End Sub

    Private Sub playsyes_CheckedChanged(sender As Object, e As EventArgs) Handles playsyes.CheckedChanged

        If playsyes.Checked = True Then
            playsno.Checked = False
            '
            ' Schreibt die Ini
            '
            writeIni(File, Section_sounds, psounds, "1")
        End If
        If playsyes.Checked = False Then
            playsno.Checked = True
        End If

    End Sub

    Private Sub playsno_CheckedChanged(sender As Object, e As EventArgs) Handles playsno.CheckedChanged

        If playsno.Checked = True Then
            playsyes.Checked = False
            '
            ' Schreibt die Ini
            '
            writeIni(File, Section_sounds, psounds, "0")
        End If
        If playsno.Checked = False Then
            playsyes.Checked = True
        End If

    End Sub
    '
    ' Twitch.tv und hitbox.tv Einstellungen
    '
    Private Sub twitchbtt_Click(sender As Object, e As EventArgs) Handles twitchbtt.Click
        apilabel.Visible = True
        '
        APItwitch.Visible = True
        APIhitbox.Visible = False
        '
        CONNECTtwitch.Visible = True
        CONNECThitbox.Visible = False
        '
        '
        '
        writeIni(File, Section_host, chost, "2")
    End Sub

    Private Sub hitboxbtt_Click(sender As Object, e As EventArgs) Handles hitboxbtt.Click
        apilabel.Visible = True
        '
        APIhitbox.Visible = True
        APItwitch.Visible = False
        '
        CONNECThitbox.Visible = True
        CONNECTtwitch.Visible = False
        '
        '
        '
        writeIni(File, Section_host, chost, "1")
    End Sub
    Private Sub CONNECTtwitch_Click(sender As Object, e As EventArgs) Handles CONNECTtwitch.Click

    End Sub
    Private Sub CONNECThitbox_Click(sender As Object, e As EventArgs) Handles CONNECThitbox.Click

    End Sub
End Class