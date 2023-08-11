Public Class MainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Main Menu"
        Dim QuitButton = New Button ''creates the button that will allow the user to close the game
        '' give the button a width and height
        QuitButton.Width = 200
        QuitButton.Height = 80
        ''gives the button a location
        QuitButton.Location = New Point(25, 350)
        ''gives the button text
        QuitButton.Text = "Quit"
        ''when the screen is resized it will remain the same distance from the bottom left of the screen as it started
        QuitButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        ''adds the button to the from
        Me.Controls.Add(QuitButton)
        ''allows the button to start and stop events during execution
        AddHandler QuitButton.MouseClick, AddressOf QuitGame

        Dim MultiButton = New Button
        MultiButton.Width = 300
        MultiButton.Height = 100
        MultiButton.Location = New Point(375, 50)
        MultiButton.Text = "Multiplayer"
        MultiButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Me.Controls.Add(MultiButton)
        AddHandler MultiButton.MouseClick, AddressOf MultiplayerMenu

        Dim SingleButton = New Button
        SingleButton.Width = 300
        SingleButton.Height = 100
        SingleButton.Location = New Point(225, 50)
        SingleButton.Text = "Single Device"
        Me.Controls.Add(SingleButton)
        AddHandler SingleButton.MouseClick, AddressOf GameStart
        SingleButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left

        WindowState = FormWindowState.Maximized ''opens the from in a maximised view instead of a small window
    End Sub

    Private Sub QuitGame()
        ''creates a message box that will ask the user if they are sure they want to close the game.
        Dim AreYouSure As DialogResult = MsgBox("Are you sure you want to quit?", MessageBoxButtons.YesNo, Title:="Quit?")
        If AreYouSure = DialogResult.Yes Then
            ''if the option chose is yes, the whole application will close.
            Application.Exit()
        End If
    End Sub

    Private Sub MultiplayerMenu()
        ''shows the multiplayer menu
        MultiMenu.Show()
        ''hides the current form (main menu)
        Me.Hide()
    End Sub

    Private Sub GameStart()
        Me.Hide()
        SingleGame.Show()

    End Sub
End Class
