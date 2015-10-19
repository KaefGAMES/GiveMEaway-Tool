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
    ' gversion = Versionsnummer welche vom Webserver überprüft wird z.B. 0.0.1, 0.0.2 usw.
    '
    '
    ' Versionsnummer für den Versionscheck
    '
    Dim gawayversion As String = "0.0.4"
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
        MsgBox("Changelog #4" & vbNewLine & "" & vbNewLine & "- Neue Keys werden jetzt in die Keys.txt geschrieben & gespeichert" & vbNewLine & "" & vbNewLine & "- Der Button für Key entfernen, die Textbox und die Bezeichnung sind vorerst nicht mehr sichtbar, bis die Funktion richtig funktioniert. :)", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
        MsgBox("Vielen Dank, dass du dich für unser kleines aber feines Tool zum Verwalten deiner GiveAway Keys entschieden hast." & vbNewLine & "" & vbNewLine & "Dieses Tool soll dich dabei unterstützen eine Liste von deinen Keys anzufertigen, für deinen aktuellen Livestream. Das Tool befindet sich noch in Entwicklung und Feedback ist gerne gesehen." & vbNewLine & "" & vbNewLine & "Besuche unsere Webseite für mehr Infos!" & vbNewLine & "www.kaefgames.de", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
        '
        ' Lädt Liste mit dem Text aus der keys.txt beim Start
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
    '
    ' UPDATER AUSFÜHREN WENN NÖTIG
    '
    Private Const versionURL = "http://81.169.254.242/gaway/current_ver.txt"

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
    '
    ' Testet vor dem Start des Updates dank der Funktion "TestInternetConnection()" ob Internet verfügbar ist
    ' Beginnt dann damit die Versionsnummer vom Webserver auszulesen und wenn diese größer ist als unsere jetzige,
    ' in der Software gespeicherte, Versionsnummer dann startet die geplante GiveMEupdate.exe während sich
    ' GiveMEaway.exe für den Updateprozess schließt um diesen nicht zu verhindern. Easy Peasy!
    '
    Sub RunUpdate()
        If TestInternetConnection() = True Then
            Try
                Dim version As Integer = Web.DownloadString(New Uri(versionURL))

                If version > CInt(gawayversion) Then
                    Process.Start("GiveMEupdate.exe")
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
End Class
