<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.LauncherPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AboutLauncher = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.BasiCalcLauncher = New System.Windows.Forms.Button()
        Me.LauncherPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LauncherPanel
        '
        Me.LauncherPanel.ColumnCount = 5
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.LauncherPanel.Controls.Add(Me.AboutLauncher, 4, 9)
        Me.LauncherPanel.Controls.Add(Me.BasiCalcLauncher, 0, 0)
        Me.LauncherPanel.Location = New System.Drawing.Point(12, 48)
        Me.LauncherPanel.Name = "LauncherPanel"
        Me.LauncherPanel.RowCount = 10
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LauncherPanel.Size = New System.Drawing.Size(510, 451)
        Me.LauncherPanel.TabIndex = 0
        '
        'AboutLauncher
        '
        Me.AboutLauncher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutLauncher.AutoSize = True
        Me.AboutLauncher.Location = New System.Drawing.Point(411, 408)
        Me.AboutLauncher.Name = "AboutLauncher"
        Me.AboutLauncher.Size = New System.Drawing.Size(96, 40)
        Me.AboutLauncher.TabIndex = 0
        Me.AboutLauncher.Text = "About"
        Me.AboutLauncher.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(13, 13)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(139, 32)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Main Menu"
        '
        'BasiCalcLauncher
        '
        Me.BasiCalcLauncher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BasiCalcLauncher.AutoSize = True
        Me.BasiCalcLauncher.Location = New System.Drawing.Point(3, 3)
        Me.BasiCalcLauncher.Name = "BasiCalcLauncher"
        Me.BasiCalcLauncher.Size = New System.Drawing.Size(96, 39)
        Me.BasiCalcLauncher.TabIndex = 1
        Me.BasiCalcLauncher.Text = "Basic Calculator"
        Me.BasiCalcLauncher.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 511)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.LauncherPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ben's Utils"
        Me.LauncherPanel.ResumeLayout(False)
        Me.LauncherPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LauncherPanel As TableLayoutPanel
    Friend WithEvents Title As Label
    Friend WithEvents AboutLauncher As Button
    Friend WithEvents BasiCalcLauncher As Button
End Class
