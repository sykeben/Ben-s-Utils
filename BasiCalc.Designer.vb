<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasiCalc
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
        Me.Number1 = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Divide = New System.Windows.Forms.Button()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Subtract = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Number2 = New System.Windows.Forms.NumericUpDown()
        Me.Equals = New System.Windows.Forms.Label()
        Me.Number3 = New System.Windows.Forms.Label()
        CType(Me.Number1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Number2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Number1
        '
        Me.Number1.AllowDrop = True
        Me.Number1.DecimalPlaces = 3
        Me.Number1.Location = New System.Drawing.Point(13, 13)
        Me.Number1.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.Number1.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(311, 20)
        Me.Number1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Divide, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Multiply, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Subtract, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Add, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(311, 35)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Divide
        '
        Me.Divide.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Divide.AutoSize = True
        Me.Divide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divide.Location = New System.Drawing.Point(234, 3)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(74, 29)
        Me.Divide.TabIndex = 3
        Me.Divide.Text = "/"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        Me.Multiply.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Multiply.AutoSize = True
        Me.Multiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiply.Location = New System.Drawing.Point(157, 3)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(71, 29)
        Me.Multiply.TabIndex = 2
        Me.Multiply.Text = "x"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Subtract
        '
        Me.Subtract.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Subtract.AutoSize = True
        Me.Subtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtract.Location = New System.Drawing.Point(80, 3)
        Me.Subtract.Name = "Subtract"
        Me.Subtract.Size = New System.Drawing.Size(71, 29)
        Me.Subtract.TabIndex = 2
        Me.Subtract.Text = "-"
        Me.Subtract.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add.AutoSize = True
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Location = New System.Drawing.Point(3, 3)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(71, 29)
        Me.Add.TabIndex = 0
        Me.Add.Text = "+"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Number2
        '
        Me.Number2.DecimalPlaces = 3
        Me.Number2.Location = New System.Drawing.Point(13, 80)
        Me.Number2.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.Number2.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(311, 20)
        Me.Number2.TabIndex = 2
        '
        'Equals
        '
        Me.Equals.AutoSize = True
        Me.Equals.Location = New System.Drawing.Point(13, 125)
        Me.Equals.Name = "Equals"
        Me.Equals.Size = New System.Drawing.Size(13, 13)
        Me.Equals.TabIndex = 3
        Me.Equals.Text = "="
        '
        'Number3
        '
        Me.Number3.AutoSize = True
        Me.Number3.Location = New System.Drawing.Point(33, 125)
        Me.Number3.Name = "Number3"
        Me.Number3.Size = New System.Drawing.Size(0, 13)
        Me.Number3.TabIndex = 4
        '
        'BasiCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 153)
        Me.Controls.Add(Me.Number3)
        Me.Controls.Add(Me.Equals)
        Me.Controls.Add(Me.Number2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Number1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BasiCalc"
        Me.Text = "BasiCalc"
        CType(Me.Number1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Number2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Number1 As NumericUpDown
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Divide As Button
    Friend WithEvents Multiply As Button
    Friend WithEvents Subtract As Button
    Friend WithEvents Add As Button
    Friend WithEvents Number2 As NumericUpDown
    Friend WithEvents Equals As Label
    Friend WithEvents Number3 As Label
End Class
