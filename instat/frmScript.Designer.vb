﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScript
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtScript
        '
        Me.txtScript.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtScript.Location = New System.Drawing.Point(0, 34)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.ReadOnly = True
        Me.txtScript.Size = New System.Drawing.Size(416, 227)
        Me.txtScript.TabIndex = 0
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClear.Location = New System.Drawing.Point(312, 0)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(104, 34)
        Me.cmdClear.TabIndex = 1
        Me.cmdClear.Text = "Clear contents"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'frmScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 261)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.txtScript)
        Me.Name = "frmScript"
        Me.ShowIcon = False
        Me.Tag = "Script_Window"
        Me.Text = "Script Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtScript As TextBox
    Friend WithEvents cmdClear As Button
End Class
