<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.Title = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.CopyrightYear = New System.Windows.Forms.Label()
        Me.CopyrightHolder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(13, 13)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(125, 32)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Ben's Utils"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(15, 45)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(43, 21)
        Me.Version.TabIndex = 1
        Me.Version.Text = "0.0.1"
        '
        'CopyrightYear
        '
        Me.CopyrightYear.AutoSize = True
        Me.CopyrightYear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyrightYear.Location = New System.Drawing.Point(212, 22)
        Me.CopyrightYear.Name = "CopyrightYear"
        Me.CopyrightYear.Size = New System.Drawing.Size(119, 21)
        Me.CopyrightYear.TabIndex = 2
        Me.CopyrightYear.Text = "Copyright 2018"
        Me.CopyrightYear.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CopyrightHolder
        '
        Me.CopyrightHolder.AutoSize = True
        Me.CopyrightHolder.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyrightHolder.Location = New System.Drawing.Point(150, 45)
        Me.CopyrightHolder.Name = "CopyrightHolder"
        Me.CopyrightHolder.Size = New System.Drawing.Size(181, 32)
        Me.CopyrightHolder.TabIndex = 3
        Me.CopyrightHolder.Text = "Benjamin Sykes"
        Me.CopyrightHolder.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 96)
        Me.Controls.Add(Me.CopyrightHolder)
        Me.Controls.Add(Me.CopyrightYear)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Version As Label
    Friend WithEvents CopyrightYear As Label
    Friend WithEvents CopyrightHolder As Label
End Class
