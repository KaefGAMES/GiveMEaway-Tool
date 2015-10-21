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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        Dim notempty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 1)
        Try
            If empty.Any Then
                MsgBox("Der Inhalt der Textboxen darf nicht leer sein.", MsgBoxStyle.Information, "GiveMEaway - Fehler!")
            End If
            If notempty.Any Then
                Dim inputFile As String = Environment.CurrentDirectory + "\keys.txt"

                gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key1.Text)

                gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key2.Text)

                gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key3.Text)

                gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key4.Text)

                gaway.aviablekeys.Items.Add(gaway.aviablekeys.Items.Count + 1 & ")" & " " & key5.Text)
                ' Speichere neuen Inhalt in die "keys.txt"
                IO.File.WriteAllLines(inputFile, gaway.aviablekeys.Items.Cast(Of String).ToArray)

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class