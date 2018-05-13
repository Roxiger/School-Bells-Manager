Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Public Class Main
    Dim btnClicked As Short
    Public flag1 As Boolean = False
    Public flag2 As Boolean = False
    Public flag3 As Boolean = False
    Private Sub DateTimer_Tick(sender As Object, e As EventArgs) Handles DateTimer.Tick
        lbDateTime.Text = Now
    End Sub ' Датата и часът в момента
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles LoopTimer.Tick

        If btnClicked = 1 Then
            If flag3 Then
                LoopTimer.Stop()
                lbState.Text = "45-мин график завършен"
            End If
            CheckModul.bellCheck1(breakLb1, txtLast1, txtNext1, 1, CheckModul.counter1, flag1)
            CheckModul.bellCheck1(startLb1, txtLast2, txtNext2, 3, CheckModul.counter2, flag2)
            CheckModul.bellCheck1(endLb1, txtLast3, txtNext3, 1, CheckModul.counter3, flag3)
        ElseIf btnClicked = 2 Then
            If flag3 Then
                LoopTimer.Stop()
                lbState.Text = "40-мин график завършен"
            End If
            CheckModul.bellCheck1(breakLb2, txtLast1, txtNext1, 1, CheckModul.counter1, flag1)
            CheckModul.bellCheck1(startLb2, txtLast2, txtNext2, 3, CheckModul.counter2, flag2)
            CheckModul.bellCheck1(endLb2, txtLast3, txtNext3, 1, CheckModul.counter3, flag3)
        ElseIf btnClicked = 3 Then
            If flag3 Then
                LoopTimer.Stop()
                lbState.Text = "Потр. график завършен"
            End If
            CheckModul.bellCheck1(breakLb3, txtLast1, txtNext1, 1, CheckModul.counter1, flag1)
            CheckModul.bellCheck1(startLb3, txtLast2, txtNext2, 3, CheckModul.counter2, flag2)
            CheckModul.bellCheck1(endLb3, txtLast3, txtNext3, 1, CheckModul.counter3, flag3)
        End If

    End Sub
    'БУТОНИ 

    Private Sub НастройкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НастройкиToolStripMenuItem.Click
        Settings.Show()
    End Sub ' падащо меню настройки
    Private Sub ИзходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИзходToolStripMenuItem.Click
        End
    End Sub ' падащо меню изход
    Private Sub ОтносноToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОтносноToolStripMenuItem.Click
        About.Show()
    End Sub ' падащо меню относно
    Private Sub set45_Click(sender As Object, e As EventArgs) Handles btnSet45.Click
        btnClicked = 1
        Try
            SerialPort.Open()
            SerialPort.Close()
            LoopTimer.Stop()
            lbState.Text = "Зададен е 45-мин. график"
            CheckModul.Nulling()
            LoopTimer.Start()

        Catch ex As Exception
            LoopTimer.Stop()
            MsgBox("Не е зададен контролер!!!", MsgBoxStyle.Critical)
        End Try

    End Sub ' бутон за задаване на 45-мин график
    Private Sub btnSet40_Click(sender As Object, e As EventArgs) Handles btnSet40.Click
        btnClicked = 2
        Try
            SerialPort.Open()
            SerialPort.Close()
            LoopTimer.Stop()
            lbState.Text = "Зададен е 40-мин. график"
            CheckModul.Nulling()
            LoopTimer.Start()
        Catch ex As Exception
            MsgBox("Не е зададен контролер!!!", MsgBoxStyle.Critical, "Грешка")
        End Try

    End Sub ' бутон за задаване на 40-мин. график
    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        btnClicked = 3


        If breakLb3.Items.Count > 2 Then
            If startLb3.Items.Count > 2 Then
                If endLb3.Items.Count > 2 Then

                    Try
                        SerialPort.Open()
                        SerialPort.Close()
                        LoopTimer.Stop()
                        lbState.Text = "Зададен е Потр. график"
                        CheckModul.Nulling()
                        LoopTimer.Start()
                    Catch ex As Exception
                        MsgBox("Не е зададен контролер!!!", MsgBoxStyle.Critical, "Грешка")
                    End Try


                Else : MsgBox("Въвели сте малко на брой часове", MsgBoxStyle.Critical, "Грешка!")
                End If
            Else : MsgBox("Въвели сте малко на брой часове", MsgBoxStyle.Critical, "Грешка!")
            End If
        Else : MsgBox("Въвели сте малко на брой часове", MsgBoxStyle.Critical, "Грешка!")
        End If
    End Sub ' бутон за задаване на Потрб. график
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        lbState.Text = "Спрян!"
        LoopTimer.Stop()
        CheckModul.Nulling()
    End Sub ' бутон за стопиране/нулиране
    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        If radioBtn1.Checked Then
            CheckModul.btnAdd(breakLb3)
        ElseIf radioBtn2.Checked Then
            CheckModul.btnAdd(startLb3)
        ElseIf radioBtn3.Checked Then
            CheckModul.btnAdd(endLb3)
        End If
    End Sub ' бутон за добавяне на часове в избраната колона
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        CheckModul.sortLb(breakLb3)
        CheckModul.sortLb(startLb3)
        CheckModul.sortLb(endLb3)
    End Sub ' бутон за сортиране на 3-те колони 
    Private Sub btnRemove1_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click
        If radioBtn1.Checked Then
            CheckModul.btnsRmvLbItms(breakLb3)
        ElseIf radioBtn2.Checked Then
            CheckModul.btnsRmvLbItms(startLb3)
        ElseIf radioBtn3.Checked Then
            CheckModul.btnsRmvLbItms(endLb3)
        End If
    End Sub  ' бутон за премахване на час от селектираната колона
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckModul.checkSettingsFile()
    End Sub ' при стартиране на приложението да се поверява дали съществува файл с настройки и да се зададе автоматично
    Private Sub btnSavelb_Click(sender As Object, e As EventArgs) Handles btnSavelb.Click
        If radioBtn1.Checked Then
            saveLbFile(breakLb3)
        ElseIf radioBtn2.Checked Then
            saveLbFile(startLb3)
        ElseIf radioBtn3.Checked Then
            saveLbFile(endLb3)
        End If
    End Sub ' бутон за запазване на файл с часове от избраната колона

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        If radioBtn1.Checked Then
            openLbFile(breakLb3)
        ElseIf radioBtn2.Checked Then
            openLbFile(startLb3)
        ElseIf radioBtn3.Checked Then
            openLbFile(endLb3)
        End If
    End Sub

    
    Private Sub btnAlarm_Click(sender As Object, e As EventArgs) Handles btnAlarm.Click

        Try
            SerialPort.Open()
            SerialPort.Close()

            LoopTimer.Stop()
            CheckModul.ringBells(2)
            lbState.Text = "Аларма"
            CheckModul.Nulling()

        Catch ex As Exception
            LoopTimer.Stop()
            MsgBox("Не е зададен контролер!!!", MsgBoxStyle.Critical)
        End Try
    End Sub
    
End Class