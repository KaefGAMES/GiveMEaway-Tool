Public Class welcome
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
    Private Const versionURL = "http://81.169.254.242/gaway/current_ver.txt"
    Dim gawayversion As String = "0.0.8"
    Dim Web As New Net.WebClient()
    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Prüft vor beginn nach vorhandenen Updates!
        '
        'TestInternetConnection()
        'RunUpdate()
        '
        ' Startet normal weiter, wenn keine Updates vorhanden sind
        '
        '
        ' Lädt übersetzungen
        '
        Dim File = Application.StartupPath + "\away.ini"
        '
        ' Bestimmt die Sektionen in der .ini
        '
        Dim Section_lang = "Language"
        '
        ' Bestimmt die "Unterpunkte" in der .ini
        '
        Dim lang = "lang"
        '
        ' Übersetzungen
        '
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
            Label1.Text = "WILLKOMMEN"
            changelog.Text = "Changelog #8" + vbNewLine + vbNewLine + "- Es ist nun möglich, Einstellungen zur Sprache, zum Sound und später für die Anbieter/Hosts vorzunehmen." + vbNewLine + "- Die 'Multiline-Key'-Funktion, funktioniert nun und lässt Keys beginnend mit einem Buchstaben (z.B. E6K732-C037-1) zu." + vbNewLine + "- Die Updater-Source kann nun eingesehen werden (siehe https://github.com/KaefGAMES/GiveMEaway-Tool)" + vbNewLine + "- Der Online-Versions-Check ist für diese Version kurzfristig de-aktiviert. Bitte behalte unsere Webseite im Auge um über neuere Versionen informiert zu bleiben!!!"
        End If
        If readLANG = "enUS" Then
            Label1.Text = "WELCOME"
            changelog.Text = "Changelog #8" + vbNewLine + vbNewLine + "- You can switch the language now in the brand NEW settings window" + vbNewLine + "- You can switch the sounds from 'On' to 'off' now...if ya want #pawsome" + vbNewLine + "- Fixed the mistake in 'Multiline-Key-Adding'-Window. :)" + vbNewLine + "- Disabled version-check in this build...sorry dudes you have to check the manual way if something changes. :/ (will be back in next version...)"
        End If
    End Sub
    Function TestInternetConnection()

        Dim ping As New Net.NetworkInformation.Ping

        Try
            ping.Send("google.de")
            Return True
        Catch ex As Exception
            Return True
        End Try
    End Function

    Sub RunUpdate()
        If TestInternetConnection() = True Then
            Try
                Dim version As Integer = Web.DownloadString(New Uri(versionURL))

                If version = CInt(gawayversion) Then
                    ' do nothing
                End If
                If version < CInt(gawayversion) Then
                    ' do nothing
                End If
                ' Versionscheck für GiveMEupdate.exe
                If version > CInt(gawayversion) Then
                    Try
                        ' Wenn neue Version verfügbar, dann hinweis anzeigen, Updater starten und Fenster schließen!
                        MsgBox("Eine neue Version von GiveMEaway ist verfügbar!", MsgBoxStyle.Information, "GiveMEAway - Ein Update ist verfügbar!")
                        Process.Start("GiveMEupdate.exe")
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.xn--kfgames-5wa.de")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("www.facebook.com/KaefGAMES")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("www.twitter.com/KaefGAMES")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("www.hitbox.tv/KaefGAMES-Entertainment")
    End Sub
End Class