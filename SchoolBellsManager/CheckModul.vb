Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Module CheckModul
    Dim Time As Date
    Public counter1 As Short = 0
    Public counter2 As Short = 0
    Public counter3 As Short = 0
    Public timer1 As Timer
    Public timer2 As Timer
    Public timer3 As Timer
    Public OpenFileDialog As OpenFileDialog
    Public SaveFileDialog As SaveFileDialog

    'Код за обработката
    Public Sub bellCheck1(Lb As ListBox, txtLast As TextBox, txtNext As TextBox, ringNum As Short, ByRef counter As Short, ByRef flag As Boolean)
        Dim result As Short

        Try

            If flag = False Then

                Time = Now.ToShortTimeString

                If counter <> Lb.Items.Count Then
                    result = DateTime.Compare(Lb.Items.Item(counter), Time)

                End If

                If result < 0 Then '0 < - listbox item е по-ранен от чч:мм(момента). '

                    txtLast.Text = Lb.Items.Item(counter)
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    counter += 1

                    If counter >= Lb.Items.Count Then
                        txtNext.Text = "-"
                        '  lbState.Text = "Завършен"
                        flag = True

                    Else
                        txtNext.Text = Lb.Items.Item(counter)
                    End If

                ElseIf result = 0 Then ' 0 - listbox item = чч:мм(момента)

                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
                    Try
                        ringBells(ringNum) ' Звъни
                    Catch ex As Exception
                        MsgBox("Не е намерен контролер!", MsgBoxStyle.Critical, ex.Message)
                        Main.LoopTimer.Stop()
                    End Try



                    txtLast.Text = Lb.Items.Item(counter)
                    counter += 1

                    If counter >= Lb.Items.Count Then
                        txtNext.Text = "-"
                        flag = True
                    Else
                        txtNext.Text = Lb.Items.Item(counter)
                    End If

                Else 'listbox item > 0   Greater than zero t1 is later than t2. '
                    txtNext.Text = Lb.Items.Item(counter)
                End If

            End If
        Catch ex As Exception
            Main.LoopTimer.Stop()
            MsgBox(ex.Message)

        End Try
    End Sub ' Метод за проверка на звънците
    Public Sub sortLb(ByRef lb As ListBox)
        Dim result As Short
        Try


            If (lb.Items.Count > 1) Then

                Dim swapped As Boolean

                Do
                    Dim count As Integer = lb.Items.Count - 1
                    swapped = False
                    While (count > 0)

                        result = DateTime.Compare(lb.Items.Item(count), lb.Items.Item(count - 1)) ' сравнява  

                        If result < 0 Then ' ако е истина разменя 2-та items

                            Dim temp As Object = lb.Items(count)
                            lb.Items(count) = lb.Items(count - 1)
                            lb.Items(count - 1) = temp
                            swapped = True
                        End If
                        ' намаля count - 1.
                        count -= 1
                    End While
                Loop While (swapped = True)
            End If
        Catch ex As Exception
            MsgBox("Грешно въведени елементи!", MsgBoxStyle.Critical, "Грешка!")
        End Try
    End Sub 'Метод за сортиране 
    Public Sub btnAdd(ByRef lb As ListBox)
        Dim dt = Nothing  'may cause a problem'
        'need a fix MAYBE not'
        If DateTime.TryParse(InputBox("Въведете час:"), dt) Then
            dt = dt.ToShortTimeString
            lb.Items.Add(dt)
        Else : MsgBox("Грешно въведени данни!", MsgBoxStyle.Critical, "Грешка!")
        End If
    End Sub 'Метод за добавяне на listbox.items
    Public Sub btnsRmvLbItms(ByRef lb As ListBox)
        lb.Items.Remove(lb.SelectedItem)
    End Sub 'метод за премахване на listbox.items'
    Public Sub ringBells(val As Short)
        Try

            If val = 1 Then
                Main.SerialPort.Open()
                Main.SerialPort.Write("1")
                Main.SerialPort.Close()
            ElseIf val = 2 Then
                Main.SerialPort.Open()
                Main.SerialPort.Write("2")
                Main.SerialPort.Close()
            ElseIf val = 3 Then
                Main.SerialPort.Open()
                Main.SerialPort.Write("3")
                Main.SerialPort.Close()
            End If

        Catch ex As Exception
            Main.LoopTimer.Stop()
            MsgBox("Не е зададен контролер", MsgBoxStyle.Critical)
            Main.lbState.Text = "Не е зададен контролер!"
        End Try
    End Sub 'Метод за звънене като изпраща число/сигнал към контролера
    Public Sub Nulling()
        counter1 = 0
        counter2 = 0
        counter3 = 0
        Main.flag1 = False
        Main.flag2 = False
        Main.flag3 = False
    End Sub 'Метод за нулиране 
    Public Sub saveSettingsFile()
        Try
            Dim writer As New System.IO.StreamWriter("settings.txt", False)
            writer.WriteLine(Settings.txtCOM.Text, 0)
            writer.WriteLine(Settings.txtBR.Text, 1)
            writer.WriteLine(Settings.txtDB.Text, 2)
            writer.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub 'Метод за записване/презаписване на файла с настройките
    Public Sub openSettingsFile()
        Try

            Settings.OpenFileDialog1.Title = "Изберете файл с настройки"
            Settings.OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
            Settings.OpenFileDialog1.FilterIndex = 1
            Settings.OpenFileDialog1.Multiselect = False
            If (Settings.OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                Dim reader As New System.IO.StreamReader(Settings.OpenFileDialog1.FileName)
                Dim allLines As List(Of String) = New List(Of String)
                Do While Not reader.EndOfStream
                    allLines.Add(reader.ReadLine())
                Loop
                reader.Close()
                Settings.txtCOM.Text = ReadLine(1, allLines)
                Settings.txtBR.Text = ReadLine(2, allLines)
                Settings.txtDB.Text = ReadLine(3, allLines)
            End If

        Catch ex As Exception
            MsgBox("Проблем при въвеждане на данните!", MsgBoxStyle.Critical)
        End Try
    End Sub ' Метод за отваряне и въвеждане на настройките за контролера
    Public Sub checkSettingsFile()
        Try
            Dim reader As New System.IO.StreamReader("settings.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Settings.txtCOM.Text = ReadLine(1, allLines)
            Settings.txtBR.Text = ReadLine(2, allLines)
            Settings.txtDB.Text = ReadLine(3, allLines)
            connectToMicroprocessor()
        Catch ex As Exception
            MsgBox("Не съществува файл с настройки! Моля, създайте нов.")
        End Try
    End Sub ' Метод за проверка дали файл с настройки съществуа и ако да - се използва , в противен случай - показва съобщение, че не съществува такъв файл и да се направи. 
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function ' Функция за взимане на искания ред
    Public Sub connectToMicroprocessor()
        Try
            Main.SerialPort.Close()
            Main.SerialPort.PortName = Settings.txtCOM.Text 'порта на xxduino/MSP430 etc 
            Main.SerialPort.BaudRate = Settings.txtBR.Text
            Main.SerialPort.DataBits = Settings.txtDB.Text
            Main.SerialPort.Parity = Parity.None
            Main.SerialPort.StopBits = StopBits.One
            Main.SerialPort.Handshake = Handshake.None
            Main.SerialPort.Encoding = System.Text.Encoding.Default 'very important!

            'Тест 
            Main.SerialPort.Open()
            Main.SerialPort.Close()

        Catch ex As Exception
            ' MsgBox(ex.Message) ' Казва съществения проблем
            MsgBox("Неуспешно свързване! Въведете валидни данни и опитайте отново", MsgBoxStyle.Critical, "Грешка")
        End Try 'Проверка на комуникацията през зададения порт с контролера
    End Sub 'Метод за свързване с контролера
    Public Sub saveLbFile(lb As ListBox)
        Try
            Main.SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"

            If Main.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim FileContent As String = ""
                For Each i As String In lb.Items
                    FileContent &= i & vbCrLf
                Next
                IO.File.WriteAllText(Main.SaveFileDialog1.FileName, FileContent)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub 'Метод за запис на файл с часове
    Public Sub openLbFile(ByRef lb As ListBox)
        Try
            Main.OpenFileDialog1.Filter = "txt files (*.txt)|*.txt"
            If Main.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                lb.Items.Clear()
                lb.Items.AddRange(IO.File.ReadAllLines(Main.OpenFileDialog1.FileName))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub ' Метод за четене на часовете от колоната от файл
End Module
