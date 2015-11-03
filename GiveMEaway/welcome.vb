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
    ' timer = Text
    ' clock = Prozess im Hintergrund der herunterzählt
    '
    '
    Private Const versionURL = "http://81.169.254.242/gaway/current_ver.txt"
    Dim gawayversion As String = "0.0.8"
    Dim Web As New Net.WebClient()
    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Wartetezeit für den "OK" Button
        '
        Button1.Enabled = False
        clock.Enabled = True
        timer.Text = Val(waittime.Text)
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
            changelog.Text = "Vielen Dank, dass du dich für unser kleines aber feines Tool zum Verwalten deiner GiveAway Keys entschieden hast." + vbNewLine + vbNewLine + "Dieses Tool soll dich dabei unterstützen eine Liste von deinen Keys anzufertigen, für deinen aktuellen Livestream. Das Tool befindet sich noch In Entwicklung und Feedback ist gerne gesehen." + vbNewLine + vbNewLine + "Besuche unsere Webseite für mehr Infos!" + vbNewLine + vbNewLine + "------------------------------------------------------------------------------" + vbNewLine + vbNewLine + "Changelog #8" + vbNewLine + vbNewLine + "- Es ist nun möglich, Einstellungen zur Sprache, zum Sound und später für die Anbieter/Hosts vorzunehmen." + vbNewLine + vbNewLine + "- Die 'Multiline-Key'-Funktion, funktioniert nun und lässt Keys beginnend mit einem Buchstaben (z.B. E6K732-C037-1) zu." + vbNewLine + vbNewLine + "- Die Updater-Source kann nun eingesehen werden (siehe https://github.com/KaefGAMES/GiveMEaway-Tool)" + vbNewLine + vbNewLine + "- Der Online-Versions-Check ist für diese Version kurzfristig de-aktiviert. Bitte behalte unsere Webseite im Auge um über neuere Versionen informiert zu bleiben!!!"
        End If
        If readLANG = "enUS" Then
            Label1.Text = "WELCOME"
            changelog.Text = "Thank you for choosing our small but nice tool for managing your giveaway Keys." + vbNewLine + vbNewLine + "This tool will help you to make a list of your keys for your current live stream. The tool is still in development and feedback is welcome." + vbNewLine + vbNewLine + "Visit us on our website for more informations!" + vbNewLine + vbNewLine + "------------------------------------------------------------------------------" + vbNewLine + vbNewLine + "Changelog #8" + vbNewLine + vbNewLine + "- You can switch the language now in the brand NEW settings window" + vbNewLine + vbNewLine + "- You can switch the sounds from 'On' to 'off' now...if ya want #pawsome" + vbNewLine + vbNewLine + "- Fixed the mistake in 'Multiline-Key-Adding'-Window. :)" + vbNewLine + vbNewLine + "- Disabled version-check in this build...sorry dudes you have to check the manual way if something changes. :/ (will be back in next version...)"
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
                        Dim readLANG = ReadIni(File, Section_lang, lang, "")
                        ' Wenn neue Version verfügbar, dann hinweis anzeigen, Updater starten und Fenster schließen!
                        If readLANG = "deDE" Then
                            MsgBox("Eine neue Version von GiveMEaway ist verfügbar!", MsgBoxStyle.Information, "GiveMEAway - Ein Update ist verfügbar!")
                            Process.Start("GiveMEupdate.exe")
                            Me.Close()
                            Exit Sub
                        End If
                        If readLANG = "enUS" Then
                            MsgBox("There's a new Version of GiveMEaway available!", MsgBoxStyle.Information, "GiveMEAway - An Update is available!")
                            Process.Start("GiveMEupdate.exe")
                            Me.Close()
                            Exit Sub
                        End If
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
        gaway.Show()
        Me.Close()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        timer.Text = Val(timer.Text) - 1
        If timer.Text = "0" Then
            timer.Visible = False
            clock.Enabled = False
            Button1.Enabled = True
        End If
    End Sub
End Class