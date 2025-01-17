﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgUseGraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.lblGraphtoUse = New System.Windows.Forms.Label()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrGraphReceiver = New instat.ucrReceiverSingle()
        Me.ucrGraphsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblGraphtoUse
        '
        Me.lblGraphtoUse.AutoSize = True
        Me.lblGraphtoUse.Location = New System.Drawing.Point(252, 45)
        Me.lblGraphtoUse.Name = "lblGraphtoUse"
        Me.lblGraphtoUse.Size = New System.Drawing.Size(73, 13)
        Me.lblGraphtoUse.TabIndex = 1
        Me.lblGraphtoUse.Text = "Graph to Use:"
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(10, 198)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(147, 23)
        Me.cmdPlotOptions.TabIndex = 3
        Me.cmdPlotOptions.Text = "Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 227)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(315, 24)
        Me.ucrSaveGraph.TabIndex = 4
        '
        'ucrGraphReceiver
        '
        Me.ucrGraphReceiver.AutoSize = True
        Me.ucrGraphReceiver.frmParent = Me
        Me.ucrGraphReceiver.Location = New System.Drawing.Point(252, 60)
        Me.ucrGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphReceiver.Name = "ucrGraphReceiver"
        Me.ucrGraphReceiver.Selector = Nothing
        Me.ucrGraphReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrGraphReceiver.strNcFilePath = ""
        Me.ucrGraphReceiver.TabIndex = 2
        Me.ucrGraphReceiver.ucrSelector = Nothing
        '
        'ucrGraphsSelector
        '
        Me.ucrGraphsSelector.AutoSize = True
        Me.ucrGraphsSelector.bDropUnusedFilterLevels = False
        Me.ucrGraphsSelector.bShowHiddenColumns = False
        Me.ucrGraphsSelector.bUseCurrentFilter = True
        Me.ucrGraphsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrGraphsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphsSelector.Name = "ucrGraphsSelector"
        Me.ucrGraphsSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrGraphsSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 254)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 5
        '
        'dlgUseGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(414, 311)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.lblGraphtoUse)
        Me.Controls.Add(Me.ucrGraphReceiver)
        Me.Controls.Add(Me.ucrGraphsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Use_Graph"
        Me.Text = "Use Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrGraphsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrGraphReceiver As ucrReceiverSingle
    Friend WithEvents lblGraphtoUse As Label
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
