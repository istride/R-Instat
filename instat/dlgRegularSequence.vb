﻿' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class dlgRegularSequence
    Dim bIsExtended As Boolean = False
    Public bFirstLoad As Boolean = True
    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("seq")
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 30
        frmMain.clsRLink.SetOutput(txtGetPreview)
        'ucrSelectDataFrame.SetColumnList(ucrColName)
        ucrNewColumnNameSelectorRegularSequence.SetDataFrameSelector(ucrSelectDataFrame)
        ucrNewColumnNameSelectorRegularSequence.SetPrefix("Sequence")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        dtpSelectorA.Visible = False
        dtpSelectorB.Visible = False

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If nudFrom.Text <> "" And nudTo.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)

        End If
    End Sub

    Private Sub rdoNumeric_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNumeric.Click
        If rdoNumeric.Checked = True Then
            dtpSelectorA.Visible = False
            dtpSelectorB.Visible = False
            chkDefineAsFactor.Visible = True

        End If
    End Sub

    Private Sub ucrSelectDataFrame_LostFocus(sender As Object, e As EventArgs) Handles ucrSelectDataFrame.LostFocus
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text)
    End Sub

    Private Sub ucrColName_LostFocus(sender As Object, e As EventArgs) Handles ucrNewColumnNameSelectorRegularSequence.LostFocus
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text)
    End Sub


    Private Sub cmdRefreshPreview_Click(sender As Object, e As EventArgs) Handles cmdRefreshPreview.Click
        frmMain.clsRLink.RunScript(ucrBase.clsRsyntax.GetScript(), ucrBase.clsRsyntax.iCallType)
        txtGetPreview.Refresh()
    End Sub

    Private Sub grpSequenceType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDates.CheckedChanged, rdoNumeric.CheckedChanged

        If rdoNumeric.Checked Then
            ucrBase.clsRsyntax.AddParameter("from", nudFrom.Value)
            ucrBase.clsRsyntax.AddParameter("to", nudTo.Value)
        Else
            dtpSelectorA.Visible = True
            dtpSelectorB.Visible = True
            nudFrom.Visible = False
            nudTo.Visible = False
            ucrBase.clsRsyntax.AddParameter("from", "as.Date('" & Format(dtpSelectorA.Value, "yyyy/MM/dd") & "')")
            ucrBase.clsRsyntax.AddParameter("to", "as.Date('" & Format(dtpSelectorB.Value, "yyyy/MM/dd") & "')")
        End If
        TestOKEnabled()
    End Sub

    Private Sub nudInstepsOf_ValueChanged(sender As Object, e As EventArgs) Handles nudInstepsOf.ValueChanged
        ucrBase.clsRsyntax.AddParameter("by", nudInstepsOf.Value)
    End Sub

    Private Sub nudRepeatValues_ValueChanged(sender As Object, e As EventArgs) Handles nudRepeatValues.ValueChanged
        ucrBase.clsRsyntax.AddParameter("length.out", nudRepeatValues.Value)
    End Sub

    Private Sub nudLength_ValueChanged(sender As Object, e As EventArgs) Handles nudLength.ValueChanged
        ucrBase.clsRsyntax.AddParameter("length", nudLength.Value)
    End Sub
End Class