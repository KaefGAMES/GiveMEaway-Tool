Public Class gaway
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
    ' gawayversion = Versionsnummer welche vom Webserver überprüft wird z.B. 0.0.1, 0.0.2 usw.
    ' copytoclip = Auswahl in Zwischenablage kopieren (STRG + C)
    '
    '
    '
    Private Const versionURL = "http://81.169.254.242/gaway/current_ver.txt"
    Dim gawayversion As String = "0.0.6"
    Dim Web As New Net.WebClient()
    '
    ' Aktionen die beim Start geladen/ausgeführt werden sollen
    '
    Private Sub gaway_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Prüft vor beginn nach vorhandenen Updates!
        '
        TestInternetConnection()
        RunUpdate()
        '
        ' Startet normal weiter, wenn keine Updates vorhanden sind
        '
        MsgBox("Changelog #6" & vbNewLine & "" & vbNewLine & "- Die GiveMEupdate.exe funktioniert nur noch auf manuellem Weg und muss vom Nutzer selbständig ausgeführt werden. Sie kann außerdem IMMER ausgeführt werden um die aktuellste Version herunterzuladen." & vbNewLine & "" & vbNewLine & "- Ein Button zum Kopieren des jeweils ausgewählten Keys ist jetzt verfügbar.", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
        MsgBox("Vielen Dank, dass du dich für unser kleines aber feines Tool zum Verwalten deiner GiveAway Keys entschieden hast." & vbNewLine & "" & vbNewLine & "Dieses Tool soll dich dabei unterstützen eine Liste von deinen Keys anzufertigen, für deinen aktuellen Livestream. Das Tool befindet sich noch in Entwicklung und Feedback ist gerne gesehen." & vbNewLine & "" & vbNewLine & "Besuche unsere Webseite für mehr Infos!" & vbNewLine & "www.kaefgames.de", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
        '
        ' Bereitet das Laden der keys.txt als Liste vor
        '
        Dim loadfileforlist As IO.StreamReader
        loadfileforlist = IO.File.OpenText(Environment.CurrentDirectory + "\keys.txt")
        Dim loadlist() As String = loadfileforlist.ReadToEnd.Split(vbNewLine)
        '
        ' Erstellt die Auswahlliste
        '
        aviablekeys.Items.AddRange(loadlist)
        loadfileforlist.Close()
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
    '
    ' Fügt eine neue Zeile zur Liste hinzu.
    '
    Private Sub addkey_Click(sender As Object, e As EventArgs) Handles addkey.Click
        ' Inhalt und Ausgabedatei als String für IO.File.WriteAllText
        Dim inputFile As String = Environment.CurrentDirectory + "\keys.txt"
        aviablekeys.Items.Add(keybox.Text)
        ' Speichere neuen Inhalt in die "keys.txt"
        IO.File.WriteAllLines(inputFile, aviablekeys.Items.Cast(Of String).ToArray)
    End Sub
    '
    ' Spielt den mitgelieferten Sound ab. Sounddatei kann und sollte angepasst werden...es sei denn man mag den Sound! Dann sollte hier nix geändert werden. ;)
    '
    Private Sub playsound_Click(sender As Object, e As EventArgs) Handles playsound.Click
        My.Computer.Audio.Play(Environment.CurrentDirectory + "\Sounds\default.wav", AudioPlayMode.Background)
    End Sub
    Private Sub remkey_Click(sender As Object, e As EventArgs) Handles remkey.Click
        '
        ' Löscht Auswahl aus der Liste und aus der Textbox, speichert diese abschließend neu in der keys.txt
        '
        Dim inputFile As String = Environment.CurrentDirectory + "\keys.txt"
        aviablekeys.Items.Remove(aviablekeys.SelectedItem)
        IO.File.WriteAllLines(inputFile, aviablekeys.Items.Cast(Of String).ToArray)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '
        ' Löscht die komplette Liste
        '
        Dim inputFile As String = Environment.CurrentDirectory + "\keys.txt"
        aviablekeys.Items.Clear()
        IO.File.WriteAllLines(inputFile, aviablekeys.Items.Cast(Of String).ToArray)
    End Sub

    Private Sub copytoclip_Click(sender As Object, e As EventArgs) Handles copytoclip.Click
        '
        ' Da normales Copy & Paste nicht funktioniert muss der Button geklickt werden. :3
        '
        My.Computer.Clipboard.SetText(aviablekeys.SelectedItem)
    End Sub
End Class
