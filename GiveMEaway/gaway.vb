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
    ' remkey = Key durch Zeilenangabe löschen
    ' chooserandom = Wählt einen zufälligen Key aus
    ' playsound = Button der den Sound abspielt...*whoa*
    ' aviablekeys = Textbox mit allen Keys
    ' keybox = Eingabefeld für neue Keys
    ' gawayversion = Versionsnummer welche vom Webserver überprüft wird z.B. 0.0.1, 0.0.2 usw.
    ' copytoclip = Auswahl in Zwischenablage kopieren (STRG + C)
    '
    '
    '
    Private Const versionURL = "http://81.169.254.242/gaway/current_ver.txt"
    Dim gawayversion As String = "0.0.7"
    Dim Web As New Net.WebClient()
    '
    ' Lädt übersetzungen
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
    ' Aktionen die beim Start geladen/ausgeführt werden sollen
    '
    Private Sub gaway_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            ' Übersetzungen // DEUTSCH/GERMAN
            addkey.Text = "Key hinzufügen"
            remkey.Text = "Key entfernen"
            clearlist.Text = "Liste leeren"
            copytoclip.Text = "Auswahl kopieren"
            opensettings.Text = "Einstellungen"
            ' Überschriften
            typekeyhere.Text = "Key hier eintippen:"
            avkeystxt.Text = "Verfügbare Keys:"
            ' Tooltips (Titel)
            addkeytooltip.ToolTipTitle = "So funktioniert's:"
            remkeytooltip.ToolTipTitle = "So funktioniert's:"
            remlist.ToolTipTitle = "So funktioniert's:"
            keyboxtooltip.ToolTipTitle = "So funktioniert's:"
            playsoundtooltip.ToolTipTitle = "So funktioniert's:"
            copytoclipb.ToolTipTitle = "So funktioniert's:"
            randomtooltip.ToolTipTitle = "So funktioniert's:"
            ' Tooltips (Text)
            addkeytooltip.SetToolTip(addkey, "Fügt einen neuen Key aus der Textbox zur Liste hinzu." + vbNewLine + "Speichert die Liste anschließend in der Keys.txt")
            remkeytooltip.SetToolTip(remkey, "Entfernt die aktuelle Auswahl aus der Liste und aus der Keys.txt")
            remlist.SetToolTip(clearlist, "Leert die komplette Liste.")
            copytoclipb.SetToolTip(copytoclip, "Kopiert deine Auswahl aus der Liste in die Zwischenablage. (STRG+C)")
            keyboxtooltip.SetToolTip(keybox, "Tippe deinen Key hier ein um Ihn der Liste hinzuzufügen.")
            playsoundtooltip.SetToolTip(playsound, "Spielt den 'standard' Sound ab. (Siehe dazu: Sounds\default.wav)")
            randomtooltip.SetToolTip(chooserandom, "Wählt einen zufälligen Key aus der Liste aus und spielt dabei einen Sound ab." + vbNewLine + "Der ausgewählte Key wird direkt in die Zwischenablage (STRG+C) kopiert und kann verschickt werden." + vbNewLine + " " + vbNewLine + "ACHTUNG: Der Inhalt der Liste darf nicht leer sein!")
        End If
        If readLANG = "enUS" Then
            ' Translations // ENGLISCH/ENGLISH
            addkey.Text = "Add Key"
            remkey.Text = "Remove Key"
            clearlist.Text = "Clear List"
            copytoclip.Text = "Copy selection"
            opensettings.Text = "Settings"
            ' Headlines
            typekeyhere.Text = "Enter new Key here:"
            avkeystxt.Text = "Aviable Keys:"
            ' Tooltips (Title)
            addkeytooltip.ToolTipTitle = "How this works:"
            remkeytooltip.ToolTipTitle = "How this works:"
            remlist.ToolTipTitle = "How this works:"
            keyboxtooltip.ToolTipTitle = "How this works:"
            playsoundtooltip.ToolTipTitle = "How this works:"
            copytoclipb.ToolTipTitle = "How this works:"
            randomtooltip.ToolTipTitle = "How this works:"
            ' Tooltips (Text)
            addkeytooltip.SetToolTip(addkey, "Adds a new Key from the Textbox into the list." + vbNewLine + "The new list gets saved afterwards into the Keys.txt")
            remkeytooltip.SetToolTip(remkey, "Removes the selection from the list and saves afterwards")
            remlist.SetToolTip(clearlist, "Clears the list.")
            copytoclipb.SetToolTip(copytoclip, "Copys the selection from the list into your clipboard. (CTRL + C)")
            keyboxtooltip.SetToolTip(keybox, "Enter your Key here to add him into the list.")
            playsoundtooltip.SetToolTip(playsound, "Play's the 'default' Soundtrack. (Look here: Sounds\default.wav)")
            randomtooltip.SetToolTip(chooserandom, "Chooses a random Key from the list and play a Sound. (Default = on)." + vbNewLine + "The choosen Key is directly in your clipboard (CTRL + C) and you can send him to the winner." + vbNewLine + " " + vbNewLine + "ATTENTION: The list can not be empty!")
        End If
        '
        ' Prüft vor beginn nach vorhandenen Updates!
        '
        'TestInternetConnection()
        'RunUpdate()
        '
        ' Startet normal weiter, wenn keine Updates vorhanden sind
        '
        MsgBox("Changelog #8" & vbNewLine & "" & vbNewLine & "- Alle Zeilen werden jetzt automatisch neu durchnummeriert wenn bspw. eine Zeile gelöscht oder beim Starten die Keys.txt neu ausgelesen wird. (Idee von nerdtopiaDE)" & vbNewLine & "" & vbNewLine & "- Im Einstellungsfenster können jetzt Einstellungen zur Sprache, dem Anbieter und später für die hitbox.tv ReDiBot Integration getätigt werden." & vbNewLine & "" & vbNewLine & "- Beim ersten Start des Programmes wird nun die Sprachauswahl angezeigt.", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
        MsgBox("Vielen Dank, dass du dich für unser kleines aber feines Tool zum Verwalten deiner GiveAway Keys entschieden hast." & vbNewLine & "" & vbNewLine & "Dieses Tool soll dich dabei unterstützen eine Liste von deinen Keys anzufertigen, für deinen aktuellen Livestream. Das Tool befindet sich noch in Entwicklung und Feedback ist gerne gesehen." & vbNewLine & "" & vbNewLine & "Besuche unsere Webseite für mehr Infos!" & vbNewLine & "www.kaefgames.de", MsgBoxStyle.Information, "GiveMEAway - Willkommen! :)")
        '
        ' Bereitet das Laden der keys.txt als Liste vor
        '
        Dim loadfileforlist As IO.StreamReader
        loadfileforlist = IO.File.OpenText(Environment.CurrentDirectory & "\keys.txt")
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
        ' Neuen Inhalt hinzufügen
        If keybox.Text = "" Then
            MessageBox.Show("Das Textfeld darf nicht leer sein.", "GiveMEaway - Fehler!")
            Exit Sub
        Else
            aviablekeys.Items.Add(aviablekeys.Items.Count + 1 & ")" & " " & keybox.Text)
            ' Speichere neuen Inhalt in die "keys.txt"
            IO.File.WriteAllLines(inputFile, aviablekeys.Items.Cast(Of String).ToArray)
            ' Setze den Inhalt des Textfeldes wieder zurück
            keybox.Text = ""
        End If
    End Sub
    '
    ' Spielt den mitgelieferten Sound ab. Sounddatei kann und sollte angepasst werden...es sei denn man mag den Sound! Dann sollte hier nix geändert werden. ;)
    '
    Private Sub playsound_Click(sender As Object, e As EventArgs) Handles playsound.Click
        ' Lese Konfiguration
        Dim readSOUND = ReadIni(File, Section_sounds, psounds, "")
        Dim readLANG = ReadIni(File, Section_lang, lang, "")
        '
        '
        If readSOUND = "1" Then
            My.Computer.Audio.Play(Environment.CurrentDirectory + "\Sounds\default.wav", AudioPlayMode.Background)
        End If
        If readSOUND = "0" And readLANG = "deDE" Then
            MessageBox.Show("Sounds sind nicht aktiviert!", "GiveMEaway - Fehler!")
        End If
        If readSOUND = "0" And readLANG = "enUS" Then
            MessageBox.Show("Sounds are not activated!", "GiveMEaway - Fehler!")
        End If
    End Sub
    Private Sub remkey_Click(sender As Object, e As EventArgs) Handles remkey.Click
        '
        ' Löscht Auswahl aus der Liste und aus der Textbox, speichert diese abschließend neu in der keys.txt
        '
        Dim inputFile As String = Environment.CurrentDirectory + "\keys.txt"
        aviablekeys.Items.Remove(aviablekeys.SelectedItem)
        IO.File.WriteAllLines(inputFile, aviablekeys.Items.Cast(Of String).ToArray)
    End Sub

    Private Sub clearlist_Click(sender As Object, e As EventArgs) Handles clearlist.Click
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

    Private Sub chooserandom_Click(sender As Object, e As EventArgs) Handles chooserandom.Click
        ' Lese Konfiguration
        Dim readSOUND = ReadIni(File, Section_sounds, psounds, "")
        Dim readLANG = ReadIni(File, Section_lang, lang, "")
        '
        ' Wählt eine zufällige Zeile in der Liste aus und speichert das Ergebnis in der Zwischenablage (STRG + C)
        '
        If aviablekeys.Items.Count = 0 And readLANG = "deDE" Then
            MessageBox.Show("Die Liste darf nicht leer sein.", "GiveMEaway - Fehler!")
            Exit Sub
        Else
            If readSOUND = "1" And readLANG = "deDE" Then
                My.Computer.Audio.Play(Environment.CurrentDirectory + "\Sounds\random.wav", AudioPlayMode.Background)
                Dim rnd As New Random
                Dim randomIndex As Integer = rnd.Next(0, aviablekeys.Items.Count - 1)
                MessageBox.Show("Es ist: " + aviablekeys.Items(randomIndex), "GiveMEaway - GiveMErandom Ergebnis")
                My.Computer.Clipboard.SetText(aviablekeys.Items(randomIndex))
                Exit Sub
            End If
        End If
        '
        If aviablekeys.Items.Count = 0 And readLANG = "deDE" Then
            MessageBox.Show("Die Liste darf nicht leer sein.", "GiveMEaway - Fehler!")
            Exit Sub
        Else
            If readSOUND = "0" And readLANG = "deDE" Then
                Dim rnd As New Random
                Dim randomIndex As Integer = rnd.Next(0, aviablekeys.Items.Count - 1)
                MessageBox.Show("Es ist: " + aviablekeys.Items(randomIndex), "GiveMEaway - GiveMErandom Ergebnis")
                My.Computer.Clipboard.SetText(aviablekeys.Items(randomIndex))
                Exit Sub
            End If
        End If
        '
        ' Englisch / English
        '
        If aviablekeys.Items.Count = 0 And readLANG = "enUS" Then
            MessageBox.Show("The list cannot be empty.", "GiveMEaway - Error!")
            Exit Sub
        Else
            If readSOUND = "1" And readLANG = "enUS" Then
                My.Computer.Audio.Play(Environment.CurrentDirectory + "\Sounds\random.wav", AudioPlayMode.Background)
                Dim rnd As New Random
                Dim randomIndex As Integer = rnd.Next(0, aviablekeys.Items.Count - 1)
                MessageBox.Show("It's: " + aviablekeys.Items(randomIndex), "GiveMEaway - GiveMErandom Result")
                My.Computer.Clipboard.SetText(aviablekeys.Items(randomIndex))
                Exit Sub
            End If
        End If
        '
        If aviablekeys.Items.Count = 0 And readLANG = "enUS" Then
            MessageBox.Show("The list cannot be empty.", "GiveMEaway - Error!")
            Exit Sub
        Else
            If readSOUND = "0" And readLANG = "enUS" Then
                Dim rnd As New Random
                Dim randomIndex As Integer = rnd.Next(0, aviablekeys.Items.Count - 1)
                MessageBox.Show("It's: " + aviablekeys.Items(randomIndex), "GiveMEaway - GiveMErandom Result")
                My.Computer.Clipboard.SetText(aviablekeys.Items(randomIndex))
                Exit Sub
            End If
        End If
    End Sub

    Private Sub plusbtt_Click(sender As Object, e As EventArgs) Handles plusbtt.Click
        '
        ' Öffnet ein Fenster zum Hinzufügen mehrerer Keys (gleichzeitig)
        '
        Mkey.Show()
    End Sub

    Private Sub opensettings_Click(sender As Object, e As EventArgs) Handles opensettings.Click
        '
        ' Öffnet das Fenster für die Einstellungen
        '
        gsettings.Show()
    End Sub
End Class
