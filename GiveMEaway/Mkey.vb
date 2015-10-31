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
End Class