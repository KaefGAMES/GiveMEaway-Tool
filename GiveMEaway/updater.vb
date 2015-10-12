Public Class updater
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
    '        _/  -"  /.'         /:/;	    GiveMEAway-Tool Updater
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
                    Try
                        ' Einblenden & Ausblenden der Texte / Download-Leiste
                        Label1.Visible = False
                        Label3.Visible = True
                        System.Threading.Thread.Sleep(3000)
                        ' Downloaden der neue Version
                        Web.DownloadFileAsync(New Uri(targetURL), Application.StartupPath & "GiveMEaway.exe")
                        System.Threading.Thread.Sleep(3000)
                        Process.Start("GiveMEaway.exe")
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Catch ex As Exception
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TestInternetConnection()
        RunUpdate()
    End Sub
End Class