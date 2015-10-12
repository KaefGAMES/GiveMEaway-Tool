Public Class Form1
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
    ' Deklaration
    ' addkey = Neuen Key hinzufügen (Button)
    ' chooserandom = Wählt einen zufälligen Key aus (N/A)
    ' aviablekeys = Textbox mit allen Keys
    ' keybox = Eingabefeld für neue Keys
    '
    ' Beim Starten Hinweis ausführen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Changelog #2" & vbNewLine & "" & vbNewLine & "- Fehlermeldung beim Klick auf 'Play Sound' behoben" & vbNewLine & "" & vbNewLine & "- Updater hinzugefügt" & vbNewLine & "- Der 'useless' Button heißt nun 'Play Sound'-Button, ay!", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
        MsgBox("Vielen Dank, dass du dich für unser kleines aber feines Tool zum Verwalten deiner GiveAway Keys entschieden hast." & vbNewLine & "" & vbNewLine & "Dieses Tool soll dich dabei unterstützen eine Liste von deinen Keys anzufertigen, für deinen aktuellen Livestream. Das Tool befindet sich noch in Entwicklung und Feedback ist gerne gesehen." & vbNewLine & "" & vbNewLine & "Besuche unsere Webseite für mehr Infos!" & vbNewLine & "www.kaefgames.de", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
        aviablekeys.Text = IO.File.ReadAllText(System.Environment.CurrentDirectory + "\keys.txt")
    End Sub
    '
    ' UPDATER AUSFÜHREN WENN NÖTIG
    '
    Private Const targetURL = "http://www.kaefgames.de/gaway/GiveMEaway.exe"
    Private Const versionURL = "http://www.kaefgames.de/gaway/current_ver.txt"

    Dim Web As New Net.WebClient()
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

                If version > CInt(gversion.Text) Then
                    Process.Start("GiveMEupdate.exe")
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    '
    '
    '
    Private Sub addkey_Click(sender As Object, e As EventArgs) Handles addkey.Click
        aviablekeys.Text &= Environment.NewLine + "" + "+" + "" + " " + " " & keybox.Text
    End Sub
    '
    '
    '
    Private Sub chooserandom_Click(sender As Object, e As EventArgs) Handles chooserandom.Click
        My.Computer.Audio.Play(System.Environment.CurrentDirectory + "\Sounds\justfun\default.wav", AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aviablekeys.Text &= Environment.NewLine + "#" + "#" + "#" & "NOT YET AVIABLE" + "#" + "#" + "#"
    End Sub
End Class
