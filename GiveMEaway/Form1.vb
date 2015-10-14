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
    ' addkey = Neuen Key hinzufügen
    ' remkey = Key durch Zeilenangabe löschen (N/A)
    ' chooserandom = Wählt einen zufälligen Key aus (N/A)
    ' playsound = Button der den Sound abspielt...*whoa*
    ' aviablekeys = Textbox mit allen Keys
    ' keybox = Eingabefeld für neue Keys
    '
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
    '
    ' Pingt google.de vor dem Update weil Google eigentlich IMMER erreichbar ist, wenn man Internet hat!
    '
    Function TestInternetConnection()

        Dim ping As New Net.NetworkInformation.Ping

        Try
            ping.Send("google.de")
            Return True
        Catch ex As Exception
            Return True
        End Try
    End Function
    ' Testet vor dem Start des Updates dank der Funktion "TestInternetConnection()" ob Internet verfügbar ist
    ' Beginnt dann damit die Versionsnummer vom Webserver auszulesen und wenn diese größer ist als unsere jetzige,
    ' in der Software gespeicherte, Versionsnummer dann startet die geplante GiveMEupdate.exe während sich
    ' GiveMEaway.exe für den Updateprozess schließt um diesen nicht zu verhindern. Easy Peasy!
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
    ' Fügt eine neue Zeile (temporär) zur Liste hinzu. Das Ziel hier ist es, die Zeile später in die keys.txt zu schreiben...
    '
    Private Sub addkey_Click(sender As Object, e As EventArgs) Handles addkey.Click
        aviablekeys.Text &= Environment.NewLine + "" + "+" + "" + " " + " " & keybox.Text
    End Sub
    '
    ' Spielt den mitgelieferten Sound ab. Sounddatei kann und sollte angepasst werden...es sei denn man mag den Sound! Dann sollte hier nix geändert werden. ;)
    '
    Private Sub playsound_Click(sender As Object, e As EventArgs) Handles playsound.Click
        My.Computer.Audio.Play(System.Environment.CurrentDirectory + "\Sounds\justfun\default.wav", AudioPlayMode.Background)
    End Sub
    '
    ' Steht ja da! Löscht allerdings später die Keys aus der keys.txt
    '
    Private Sub remkey_Click(sender As Object, e As EventArgs) Handles remkey.Click
        aviablekeys.Text &= Environment.NewLine + "#" + "#" + "#" & "NOT YET AVIABLE" + "#" + "#" + "#"
    End Sub
End Class
