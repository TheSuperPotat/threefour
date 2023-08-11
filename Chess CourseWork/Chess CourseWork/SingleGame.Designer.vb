<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ChessBoard = New System.Windows.Forms.PictureBox()
        Me.ResignButton = New System.Windows.Forms.Button()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.TurnLabel = New System.Windows.Forms.Label()
        CType(Me.ChessBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChessBoard
        '
        Me.ChessBoard.Location = New System.Drawing.Point(28, 120)
        Me.ChessBoard.Name = "ChessBoard"
        Me.ChessBoard.Size = New System.Drawing.Size(400, 400)
        Me.ChessBoard.TabIndex = 0
        Me.ChessBoard.TabStop = False
        '
        'ResignButton
        '
        Me.ResignButton.Location = New System.Drawing.Point(514, 120)
        Me.ResignButton.Name = "ResignButton"
        Me.ResignButton.Size = New System.Drawing.Size(75, 75)
        Me.ResignButton.TabIndex = 1
        Me.ResignButton.Text = "Resign"
        Me.ResignButton.UseVisualStyleBackColor = True
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(514, 201)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(75, 75)
        Me.DrawButton.TabIndex = 2
        Me.DrawButton.Text = "Offer Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'TurnLabel
        '
        Me.TurnLabel.AutoSize = True
        Me.TurnLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TurnLabel.Location = New System.Drawing.Point(514, 347)
        Me.TurnLabel.Name = "TurnLabel"
        Me.TurnLabel.Size = New System.Drawing.Size(0, 28)
        Me.TurnLabel.TabIndex = 3
        '
        'SingleGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.TurnLabel)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.ResignButton)
        Me.Controls.Add(Me.ChessBoard)
        Me.Name = "SingleGame"
        Me.Text = "SingleGame"
        CType(Me.ChessBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChessBoard As PictureBox
    Friend WithEvents ResignButton As Button
    Friend WithEvents DrawButton As Button
    Friend WithEvents TurnLabel As Label
End Class
