<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.email1 = New System.Windows.Forms.TextBox()
        Me.number1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dob1 = New System.Windows.Forms.DateTimePicker()
        Me.gender1 = New System.Windows.Forms.ComboBox()
        Me.id1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.Location = New System.Drawing.Point(34, 73)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(109, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Full Name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label2.Location = New System.Drawing.Point(34, 117)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(147, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Email Address"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label3.Location = New System.Drawing.Point(34, 157)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(107, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Mobile No"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label4.Location = New System.Drawing.Point(34, 198)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(48, 20)
        Me.label4.TabIndex = 3
        Me.label4.Text = "DOB"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label5.Location = New System.Drawing.Point(34, 241)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(81, 20)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Gender"
        '
        'name1
        '
        Me.name1.Location = New System.Drawing.Point(231, 70)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(216, 23)
        Me.name1.TabIndex = 5
        '
        'email1
        '
        Me.email1.Location = New System.Drawing.Point(231, 114)
        Me.email1.Name = "email1"
        Me.email1.Size = New System.Drawing.Size(216, 23)
        Me.email1.TabIndex = 6
        '
        'number1
        '
        Me.number1.Location = New System.Drawing.Point(231, 158)
        Me.number1.Name = "number1"
        Me.number1.Size = New System.Drawing.Size(216, 23)
        Me.number1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(231, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(372, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dob1
        '
        Me.dob1.CustomFormat = "dd/MMM/yyyy"
        Me.dob1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob1.Location = New System.Drawing.Point(231, 195)
        Me.dob1.Name = "dob1"
        Me.dob1.Size = New System.Drawing.Size(216, 23)
        Me.dob1.TabIndex = 13
        '
        'gender1
        '
        Me.gender1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender1.FormattingEnabled = True
        Me.gender1.Items.AddRange(New Object() {"Male ", "Female"})
        Me.gender1.Location = New System.Drawing.Point(231, 238)
        Me.gender1.Name = "gender1"
        Me.gender1.Size = New System.Drawing.Size(216, 23)
        Me.gender1.TabIndex = 14
        '
        'id1
        '
        Me.id1.Location = New System.Drawing.Point(231, 28)
        Me.id1.Name = "id1"
        Me.id1.Size = New System.Drawing.Size(216, 23)
        Me.id1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(34, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ID"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(517, 327)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.id1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gender1)
        Me.Controls.Add(Me.dob1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.number1)
        Me.Controls.Add(Me.email1)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Forms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents name1 As TextBox
    Friend WithEvents email1 As TextBox
    Friend WithEvents number1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dob1 As DateTimePicker
    Friend WithEvents gender1 As ComboBox
    Friend WithEvents id1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
End Class
