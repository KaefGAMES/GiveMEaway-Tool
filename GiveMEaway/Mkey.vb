Public Class Mkey
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputFile As String = Environment.CurrentDirectory + "\keys.txt"

        gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & Key1.Text)

        gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key2.Text)

        gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key3.Text)

        gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key4.Text)

        gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key5.Text)
        ' Speichere neuen Inhalt in die "keys.txt"
        IO.File.WriteAllLines(inputFile, gaway.aviablekeys.Items.Cast(Of String).ToArray)

        Me.Close()
    End Sub

    Private Sub Mkey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Label1.Text = "Mehrere Keys hinzufügen"
            Button1.Text = "Keys hinzufügen"
        End If
        If readLANG = "enUS" Then
            ' Translations // ENGLISCH/ENGLISH
            Label1.Text = "Add several Keys"
            Button1.Text = "Add Keys"
        End If
    End Sub
End Class