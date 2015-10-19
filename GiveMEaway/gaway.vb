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
    Dim gawayversion As String = "0.0.5"
    '
    ' Aktionen die beim Start geladen/ausgeführt werden sollen
    '
    Private Sub gaway_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Prüft vor beginn nach vorhandenen Updates!
        '
        Process.Start("GiveMEupdate.exe")
        '
        ' Startet normal weiter, wenn keine Updates vorhanden sind
        '
        MsgBox("Changelog #5" & vbNewLine & "" & vbNewLine & "- Das entfernen von Keys ist jetzt möglich, wähle einfach die Zeile aus und klick auf den Button" & vbNewLine & "" & vbNewLine & "- Ein Button zum leeren der kompletten Liste ist jetzt verfügbar" & vbNewLine & "" & vbNewLine & "- Der Play Sound-Button ist jetzt etwas größer" & vbNewLine & "" & vbNewLine & "- Die unschöne Textbox zum entfernen einer Zeile ist nicht länger nötig und wurde entfernt. Wähle die Zeile einfach aus, die du löschen möchtest...", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
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
End Class
