﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAvMk = New System.Windows.Forms.TextBox()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.lstStud = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(48, 102)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(132, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Student Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(189, 102)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(132, 22)
        Me.txtLastName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 34)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date of Birth" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(d/m/yyyy)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(331, 102)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(132, 22)
        Me.txtDOB.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(477, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 34)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(m or f)"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(472, 102)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(132, 22)
        Me.txtGender.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(610, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 34)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Average Mk " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0-100)"
        '
        'txtAvMk
        '
        Me.txtAvMk.Location = New System.Drawing.Point(613, 102)
        Me.txtAvMk.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAvMk.Name = "txtAvMk"
        Me.txtAvMk.Size = New System.Drawing.Size(132, 22)
        Me.txtAvMk.TabIndex = 9
        '
        'btnAddStud
        '
        Me.btnAddStud.Location = New System.Drawing.Point(613, 156)
        Me.btnAddStud.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddStud.Name = "btnAddStud"
        Me.btnAddStud.Size = New System.Drawing.Size(139, 28)
        Me.btnAddStud.TabIndex = 11
        Me.btnAddStud.Text = "Add Student"
        Me.btnAddStud.UseVisualStyleBackColor = True
        '
        'lstStud
        '
        Me.lstStud.FormattingEnabled = True
        Me.lstStud.ItemHeight = 16
        Me.lstStud.Location = New System.Drawing.Point(48, 249)
        Me.lstStud.Margin = New System.Windows.Forms.Padding(4)
        Me.lstStud.Name = "lstStud"
        Me.lstStud.Size = New System.Drawing.Size(709, 196)
        Me.lstStud.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 225)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of entered students (for testing)"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(48, 156)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(129, 22)
        Me.txtPhone.TabIndex = 17
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(207, 156)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(58, 21)
        Me.chkPaid.TabIndex = 6
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 481)
        Me.Controls.Add(Me.chkPaid)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstStud)
        Me.Controls.Add(Me.btnAddStud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAvMk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "v1.7.5 Student entry form - Validation on Submit  - still 1 error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAvMk As TextBox
    Friend WithEvents btnAddStud As Button


    Friend WithEvents lstStud As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents chkPaid As CheckBox
End Class
