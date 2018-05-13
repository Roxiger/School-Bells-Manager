Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Settings
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
     connectToMicroprocessor()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        CheckModul.openSettingsFile()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CheckModul.saveSettingsFile()
    End Sub
End Class