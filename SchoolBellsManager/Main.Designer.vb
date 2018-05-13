<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.endLb1 = New System.Windows.Forms.ListBox()
        Me.breakLb1 = New System.Windows.Forms.ListBox()
        Me.startLb1 = New System.Windows.Forms.ListBox()
        Me.btnSet45 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.endLb2 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.startLb2 = New System.Windows.Forms.ListBox()
        Me.breakLb2 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSet40 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnSavelb = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.radioBtn3 = New System.Windows.Forms.RadioButton()
        Me.radioBtn2 = New System.Windows.Forms.RadioButton()
        Me.radioBtn1 = New System.Windows.Forms.RadioButton()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.endLb3 = New System.Windows.Forms.ListBox()
        Me.btnRemove1 = New System.Windows.Forms.Button()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.breakLb3 = New System.Windows.Forms.ListBox()
        Me.startLb3 = New System.Windows.Forms.ListBox()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNext3 = New System.Windows.Forms.TextBox()
        Me.txtLast3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNext2 = New System.Windows.Forms.TextBox()
        Me.txtLast2 = New System.Windows.Forms.TextBox()
        Me.txtNext1 = New System.Windows.Forms.TextBox()
        Me.lblLast1 = New System.Windows.Forms.Label()
        Me.txtLast1 = New System.Windows.Forms.TextBox()
        Me.lblNext1 = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.DateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lbDateTime = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbState = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтносноToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnAlarm = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabControl.Location = New System.Drawing.Point(187, 55)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(703, 426)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.SchoolBellsManager.My.Resources.Resources._2014_02_19_23__________707
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.endLb1)
        Me.TabPage1.Controls.Add(Me.breakLb1)
        Me.TabPage1.Controls.Add(Me.startLb1)
        Me.TabPage1.Controls.Add(Me.btnSet45)
        Me.TabPage1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(695, 394)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "45-мин. граф"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Snow
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(429, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Край на час(1)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Snow
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(166, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 32)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Край на" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "междучасието(1)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Snow
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 32)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Начало" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "на час(3)"
        '
        'endLb1
        '
        Me.endLb1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.endLb1.FormattingEnabled = True
        Me.endLb1.ItemHeight = 16
        Me.endLb1.Items.AddRange(New Object() {"8:30", "9:25", "10:20", "11:35", "12:25", "13:15", "14:05", "14:55"})
        Me.endLb1.Location = New System.Drawing.Point(432, 70)
        Me.endLb1.Name = "endLb1"
        Me.endLb1.Size = New System.Drawing.Size(80, 212)
        Me.endLb1.TabIndex = 50
        '
        'breakLb1
        '
        Me.breakLb1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.breakLb1.FormattingEnabled = True
        Me.breakLb1.ItemHeight = 16
        Me.breakLb1.Items.AddRange(New Object() {"7:40", "8:35", "9:30", "10:45", "11:38", "12:28", "13:18", "14:08"})
        Me.breakLb1.Location = New System.Drawing.Point(169, 70)
        Me.breakLb1.Name = "breakLb1"
        Me.breakLb1.Size = New System.Drawing.Size(80, 212)
        Me.breakLb1.TabIndex = 49
        '
        'startLb1
        '
        Me.startLb1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.startLb1.FormattingEnabled = True
        Me.startLb1.ItemHeight = 16
        Me.startLb1.Items.AddRange(New Object() {"7:45", "8:40", "9:35", "10:50", "11:40", "12:30", "13:20", "14:10"})
        Me.startLb1.Location = New System.Drawing.Point(299, 70)
        Me.startLb1.Name = "startLb1"
        Me.startLb1.Size = New System.Drawing.Size(80, 212)
        Me.startLb1.TabIndex = 48
        '
        'btnSet45
        '
        Me.btnSet45.Location = New System.Drawing.Point(273, 330)
        Me.btnSet45.Name = "btnSet45"
        Me.btnSet45.Size = New System.Drawing.Size(150, 25)
        Me.btnSet45.TabIndex = 1
        Me.btnSet45.Text = "Задай този график"
        Me.btnSet45.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = Global.SchoolBellsManager.My.Resources.Resources._2014_02_19_23__________707
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.endLb2)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.startLb2)
        Me.TabPage2.Controls.Add(Me.breakLb2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.btnSet40)
        Me.TabPage2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(695, 394)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "40-мин. Граф"
        '
        'endLb2
        '
        Me.endLb2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.endLb2.FormattingEnabled = True
        Me.endLb2.ItemHeight = 16
        Me.endLb2.Items.AddRange(New Object() {"8:25", "9:15", "10:05", "11:15", "12:00", "12:45", "13:30", "14:15"})
        Me.endLb2.Location = New System.Drawing.Point(432, 70)
        Me.endLb2.Name = "endLb2"
        Me.endLb2.Size = New System.Drawing.Size(80, 212)
        Me.endLb2.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Snow
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(429, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Край на час(1)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Snow
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 32)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Край на" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "междучасието(1)"
        '
        'startLb2
        '
        Me.startLb2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.startLb2.FormattingEnabled = True
        Me.startLb2.ItemHeight = 16
        Me.startLb2.Items.AddRange(New Object() {"7:45", "8:35", "9:25", "10:35", "11:20", "12:05", "12:50", "13:30"})
        Me.startLb2.Location = New System.Drawing.Point(299, 70)
        Me.startLb2.Name = "startLb2"
        Me.startLb2.Size = New System.Drawing.Size(80, 212)
        Me.startLb2.TabIndex = 54
        '
        'breakLb2
        '
        Me.breakLb2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.breakLb2.FormattingEnabled = True
        Me.breakLb2.ItemHeight = 16
        Me.breakLb2.Items.AddRange(New Object() {"7:40", "8:30", "9:20", "10:30", "11:18", "12:03", "12:48", "13:33"})
        Me.breakLb2.Location = New System.Drawing.Point(169, 70)
        Me.breakLb2.Name = "breakLb2"
        Me.breakLb2.Size = New System.Drawing.Size(80, 212)
        Me.breakLb2.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Snow
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 32)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Начало" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "на час(3)"
        '
        'btnSet40
        '
        Me.btnSet40.Location = New System.Drawing.Point(273, 330)
        Me.btnSet40.Name = "btnSet40"
        Me.btnSet40.Size = New System.Drawing.Size(150, 25)
        Me.btnSet40.TabIndex = 1
        Me.btnSet40.Text = "Задай този график"
        Me.btnSet40.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.SchoolBellsManager.My.Resources.Resources._2014_02_19_23__________707
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.btnOpenFile)
        Me.TabPage3.Controls.Add(Me.btnSavelb)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.radioBtn3)
        Me.TabPage3.Controls.Add(Me.radioBtn2)
        Me.TabPage3.Controls.Add(Me.radioBtn1)
        Me.TabPage3.Controls.Add(Me.btnSort)
        Me.TabPage3.Controls.Add(Me.endLb3)
        Me.TabPage3.Controls.Add(Me.btnRemove1)
        Me.TabPage3.Controls.Add(Me.btnAdd1)
        Me.TabPage3.Controls.Add(Me.breakLb3)
        Me.TabPage3.Controls.Add(Me.startLb3)
        Me.TabPage3.Controls.Add(Me.btnCustom)
        Me.TabPage3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(695, 394)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Потр. граф"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(30, 87)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(89, 23)
        Me.btnOpenFile.TabIndex = 58
        Me.btnOpenFile.Text = "Отвори"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnSavelb
        '
        Me.btnSavelb.Location = New System.Drawing.Point(30, 157)
        Me.btnSavelb.Name = "btnSavelb"
        Me.btnSavelb.Size = New System.Drawing.Size(89, 23)
        Me.btnSavelb.TabIndex = 57
        Me.btnSavelb.Text = "Запази "
        Me.btnSavelb.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Snow
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(429, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Край на час(1)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Snow
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(166, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 32)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Край на" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "междучасието(1)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Snow
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.Location = New System.Drawing.Point(312, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 32)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Начало" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "на час(3)"
        '
        'radioBtn3
        '
        Me.radioBtn3.AutoSize = True
        Me.radioBtn3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.radioBtn3.Location = New System.Drawing.Point(469, 288)
        Me.radioBtn3.Name = "radioBtn3"
        Me.radioBtn3.Size = New System.Drawing.Size(14, 13)
        Me.radioBtn3.TabIndex = 53
        Me.radioBtn3.TabStop = True
        Me.radioBtn3.UseVisualStyleBackColor = True
        '
        'radioBtn2
        '
        Me.radioBtn2.AutoSize = True
        Me.radioBtn2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.radioBtn2.Location = New System.Drawing.Point(340, 288)
        Me.radioBtn2.Name = "radioBtn2"
        Me.radioBtn2.Size = New System.Drawing.Size(14, 13)
        Me.radioBtn2.TabIndex = 52
        Me.radioBtn2.TabStop = True
        Me.radioBtn2.UseVisualStyleBackColor = True
        '
        'radioBtn1
        '
        Me.radioBtn1.AutoSize = True
        Me.radioBtn1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.radioBtn1.Location = New System.Drawing.Point(202, 288)
        Me.radioBtn1.Name = "radioBtn1"
        Me.radioBtn1.Size = New System.Drawing.Size(14, 13)
        Me.radioBtn1.TabIndex = 51
        Me.radioBtn1.TabStop = True
        Me.radioBtn1.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(571, 225)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(89, 23)
        Me.btnSort.TabIndex = 49
        Me.btnSort.Text = "Сортирай"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'endLb3
        '
        Me.endLb3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.endLb3.FormattingEnabled = True
        Me.endLb3.ItemHeight = 16
        Me.endLb3.Location = New System.Drawing.Point(432, 70)
        Me.endLb3.Name = "endLb3"
        Me.endLb3.Size = New System.Drawing.Size(80, 212)
        Me.endLb3.TabIndex = 50
        '
        'btnRemove1
        '
        Me.btnRemove1.Location = New System.Drawing.Point(571, 157)
        Me.btnRemove1.Name = "btnRemove1"
        Me.btnRemove1.Size = New System.Drawing.Size(89, 23)
        Me.btnRemove1.TabIndex = 48
        Me.btnRemove1.Text = "Премахни"
        Me.btnRemove1.UseVisualStyleBackColor = True
        '
        'btnAdd1
        '
        Me.btnAdd1.Location = New System.Drawing.Point(571, 87)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(89, 23)
        Me.btnAdd1.TabIndex = 47
        Me.btnAdd1.Text = "Добави"
        Me.btnAdd1.UseVisualStyleBackColor = True
        '
        'breakLb3
        '
        Me.breakLb3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.breakLb3.FormattingEnabled = True
        Me.breakLb3.ItemHeight = 16
        Me.breakLb3.Location = New System.Drawing.Point(169, 70)
        Me.breakLb3.Name = "breakLb3"
        Me.breakLb3.Size = New System.Drawing.Size(80, 212)
        Me.breakLb3.TabIndex = 46
        '
        'startLb3
        '
        Me.startLb3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.startLb3.FormattingEnabled = True
        Me.startLb3.ItemHeight = 16
        Me.startLb3.Location = New System.Drawing.Point(307, 70)
        Me.startLb3.Name = "startLb3"
        Me.startLb3.Size = New System.Drawing.Size(80, 212)
        Me.startLb3.TabIndex = 45
        '
        'btnCustom
        '
        Me.btnCustom.Location = New System.Drawing.Point(273, 330)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(150, 25)
        Me.btnCustom.TabIndex = 0
        Me.btnCustom.Text = "Задай този график"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(846, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Дата/Час:"
        '
        'txtNext3
        '
        Me.txtNext3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtNext3.Location = New System.Drawing.Point(620, 612)
        Me.txtNext3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNext3.Name = "txtNext3"
        Me.txtNext3.Size = New System.Drawing.Size(80, 22)
        Me.txtNext3.TabIndex = 43
        '
        'txtLast3
        '
        Me.txtLast3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtLast3.Location = New System.Drawing.Point(620, 572)
        Me.txtLast3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLast3.Name = "txtLast3"
        Me.txtLast3.Size = New System.Drawing.Size(80, 22)
        Me.txtLast3.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(617, 552)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Край на час"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(323, 552)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Край на междучасие"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(483, 552)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Начало на час"
        '
        'txtNext2
        '
        Me.txtNext2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtNext2.Location = New System.Drawing.Point(486, 612)
        Me.txtNext2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNext2.Name = "txtNext2"
        Me.txtNext2.Size = New System.Drawing.Size(80, 22)
        Me.txtNext2.TabIndex = 38
        '
        'txtLast2
        '
        Me.txtLast2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtLast2.Location = New System.Drawing.Point(486, 572)
        Me.txtLast2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLast2.Name = "txtLast2"
        Me.txtLast2.Size = New System.Drawing.Size(80, 22)
        Me.txtLast2.TabIndex = 37
        '
        'txtNext1
        '
        Me.txtNext1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtNext1.Location = New System.Drawing.Point(357, 612)
        Me.txtNext1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNext1.Name = "txtNext1"
        Me.txtNext1.Size = New System.Drawing.Size(80, 22)
        Me.txtNext1.TabIndex = 36
        '
        'lblLast1
        '
        Me.lblLast1.AutoSize = True
        Me.lblLast1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblLast1.Location = New System.Drawing.Point(184, 577)
        Me.lblLast1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLast1.Name = "lblLast1"
        Me.lblLast1.Size = New System.Drawing.Size(143, 16)
        Me.lblLast1.TabIndex = 35
        Me.lblLast1.Text = "Последния звънец->"
        '
        'txtLast1
        '
        Me.txtLast1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtLast1.Location = New System.Drawing.Point(357, 574)
        Me.txtLast1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLast1.Name = "txtLast1"
        Me.txtLast1.Size = New System.Drawing.Size(80, 22)
        Me.txtLast1.TabIndex = 34
        '
        'lblNext1
        '
        Me.lblNext1.AutoSize = True
        Me.lblNext1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblNext1.Location = New System.Drawing.Point(184, 615)
        Me.lblNext1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNext1.Name = "lblNext1"
        Me.lblNext1.Size = New System.Drawing.Size(147, 16)
        Me.lblNext1.TabIndex = 33
        Me.lblNext1.Text = "Следващия звънец ->"
        '
        'SerialPort
        '
        Me.SerialPort.PortName = "COM50"
        '
        'DateTimer
        '
        Me.DateTimer.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbDateTime
        '
        Me.lbDateTime.AutoSize = True
        Me.lbDateTime.BackColor = System.Drawing.Color.Snow
        Me.lbDateTime.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.lbDateTime.Location = New System.Drawing.Point(925, 30)
        Me.lbDateTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDateTime.Name = "lbDateTime"
        Me.lbDateTime.Size = New System.Drawing.Size(35, 16)
        Me.lbDateTime.TabIndex = 45
        Me.lbDateTime.Text = "date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Snow
        Me.Label14.Location = New System.Drawing.Point(12, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 16)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Състояние:"
        '
        'lbState
        '
        Me.lbState.AutoSize = True
        Me.lbState.BackColor = System.Drawing.Color.Snow
        Me.lbState.Location = New System.Drawing.Point(101, 30)
        Me.lbState.Name = "lbState"
        Me.lbState.Size = New System.Drawing.Size(115, 16)
        Me.lbState.TabIndex = 48
        Me.lbState.Text = "Не е стартирано"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(477, 488)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(116, 23)
        Me.btnStop.TabIndex = 49
        Me.btnStop.Text = "Спри/Нулирай"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1071, 25)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НастройкиToolStripMenuItem, Me.ОтносноToolStripMenuItem, Me.ИзходToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripDropDownButton1.Text = "Меню"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'ОтносноToolStripMenuItem
        '
        Me.ОтносноToolStripMenuItem.Name = "ОтносноToolStripMenuItem"
        Me.ОтносноToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ОтносноToolStripMenuItem.Text = "Относно"
        '
        'ИзходToolStripMenuItem
        '
        Me.ИзходToolStripMenuItem.Name = "ИзходToolStripMenuItem"
        Me.ИзходToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ИзходToolStripMenuItem.Text = "Изход"
        '
        'LoopTimer
        '
        Me.LoopTimer.Interval = 500
        '
        'btnAlarm
        '
        Me.btnAlarm.Location = New System.Drawing.Point(928, 126)
        Me.btnAlarm.Name = "btnAlarm"
        Me.btnAlarm.Size = New System.Drawing.Size(90, 23)
        Me.btnAlarm.TabIndex = 52
        Me.btnAlarm.Text = "АЛАРМА"
        Me.btnAlarm.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SchoolBellsManager.My.Resources.Resources._2014_02_19_23__________707
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1071, 668)
        Me.Controls.Add(Me.btnAlarm)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lbState)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbDateTime)
        Me.Controls.Add(Me.txtLast1)
        Me.Controls.Add(Me.lblLast1)
        Me.Controls.Add(Me.txtNext3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLast3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNext2)
        Me.Controls.Add(Me.txtLast2)
        Me.Controls.Add(Me.txtNext1)
        Me.Controls.Add(Me.lblNext1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.Text = "School Bells Manager"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtNext3 As System.Windows.Forms.TextBox
    Friend WithEvents txtLast3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNext2 As System.Windows.Forms.TextBox
    Friend WithEvents txtLast2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNext1 As System.Windows.Forms.TextBox
    Friend WithEvents lblLast1 As System.Windows.Forms.Label
    Friend WithEvents txtLast1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNext1 As System.Windows.Forms.Label
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents DateTimer As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lbDateTime As System.Windows.Forms.Label
    Friend WithEvents btnSet45 As System.Windows.Forms.Button
    Friend WithEvents btnSet40 As System.Windows.Forms.Button
    Friend WithEvents btnCustom As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbState As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents radioBtn3 As System.Windows.Forms.RadioButton
    Friend WithEvents radioBtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioBtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents endLb3 As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove1 As System.Windows.Forms.Button
    Friend WithEvents btnAdd1 As System.Windows.Forms.Button
    Friend WithEvents breakLb3 As System.Windows.Forms.ListBox
    Friend WithEvents startLb3 As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents endLb1 As System.Windows.Forms.ListBox
    Friend WithEvents breakLb1 As System.Windows.Forms.ListBox
    Friend WithEvents startLb1 As System.Windows.Forms.ListBox
    Friend WithEvents endLb2 As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents startLb2 As System.Windows.Forms.ListBox
    Friend WithEvents breakLb2 As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents НастройкиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents btnSavelb As System.Windows.Forms.Button
    Friend WithEvents LoopTimer As System.Windows.Forms.Timer
    Friend WithEvents ОтносноToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAlarm As System.Windows.Forms.Button

End Class
