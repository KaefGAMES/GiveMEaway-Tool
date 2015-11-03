Public Class gupdate
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
    '        _/  -"  /.'         /:/;	    GiveMEupdate - Zum Updaten von GiveMEaway
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
    ' Url von welcher der Download stattfinden wird.
    Private Const targetURL = "http://81.169.254.242/gaway/GiveMEaway.rar"
    '
    ' Deklaration
    ' Downloadbtt = Download Starten Button
    ' Cancelbtt = Abbrechen Button
    ' pbar = Progress Bar
    ' dpfad = Downloadpfad wird beim Start ausgewählt + Ist nicht sichtbar (Ändernbutton vllt. später)
    '
    Public WithEvents wc As New Net.WebClient()

    Private Sub gupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Downloadbtt.Text = "Download starten"
            cancelbtt.Text = "Download abbrechen"
            Label2.Text = "Weil's so einfach sein kann..."
        End If
        If readLANG = "enUS" Then
            Downloadbtt.Text = "Begin download"
            cancelbtt.Text = "End download"
            Label2.Text = "'cause it can be so easy..."
        End If
        cancelbtt.Enabled = False
    End Sub
    '
    '
    '
    '
    Private Sub Downloadbtt_Click(sender As Object, e As EventArgs) Handles Downloadbtt.Click
        If IO.File.Exists(Environment.CurrentDirectory + "\GiveMEaway.exe") Then IO.File.Delete(Environment.CurrentDirectory + "\GiveMEaway.exe")
        wc.DownloadFileAsync(New Uri(targetURL), Environment.CurrentDirectory + "\GiveMEaway.rar")

        cancelbtt.Enabled = True
        Downloadbtt.Enabled = False
    End Sub
    '
    '
    '
    '
    Private Sub wc_DownloadProgressChanged(sender As Object, e As Net.DownloadProgressChangedEventArgs) Handles wc.DownloadProgressChanged
        ' Zeigt den Status des Downloads in der ProgressBar an.
        pbar.Value = e.ProgressPercentage
    End Sub
    Private Sub wc_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles wc.DownloadFileCompleted
        MsgBox("Du hast jetzt die aktuellste Version von GiveMEaway. Bitte entpacke die heruntergeladene Datei in das gleiche Verzeichnis von GiveMEaway!", MsgBoxStyle.Information, "GiveMEupdate - Download abgeschlossen!")
        pbar.Value = 0
        cancelbtt.Enabled = False
        Downloadbtt.Enabled = True
        Me.Close()
    End Sub
    '
    '
    '
    '
    Private Sub Cancelbtt_Click(sender As Object, e As EventArgs) Handles cancelbtt.Click
        ' Bricht den Download ab und löscht die Datei anschließend
        wc.CancelAsync()

        pbar.Value = 0

        If IO.File.Exists(Environment.CurrentDirectory + "\GiveMEaway.rar") Then IO.File.Delete(Environment.CurrentDirectory + "\GiveMEaway.rar")
        cancelbtt.Enabled = False
        Downloadbtt.Enabled = True
    End Sub
End Class
