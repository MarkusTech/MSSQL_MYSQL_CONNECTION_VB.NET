<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveInfo
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        idtxt = New TextBox()
        lnametxt = New TextBox()
        mnametxt = New TextBox()
        fnametxt = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(134, 288)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 79)
        Button1.TabIndex = 0
        Button1.Text = "REGISTER (MSSQL)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(349, 288)
        Button2.Name = "Button2"
        Button2.Size = New Size(170, 79)
        Button2.TabIndex = 1
        Button2.Text = "REGISTER (MYSQL)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(89, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 21)
        Label1.TabIndex = 2
        Label1.Text = "ID NO:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(89, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 21)
        Label2.TabIndex = 3
        Label2.Text = "LAST NAME:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(89, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 21)
        Label3.TabIndex = 4
        Label3.Text = "MIDDLE NAME:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(89, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 21)
        Label4.TabIndex = 5
        Label4.Text = "FIRST NAME: "
        ' 
        ' idtxt
        ' 
        idtxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        idtxt.Location = New Point(277, 50)
        idtxt.Name = "idtxt"
        idtxt.Size = New Size(265, 29)
        idtxt.TabIndex = 6
        ' 
        ' lnametxt
        ' 
        lnametxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lnametxt.Location = New Point(277, 227)
        lnametxt.Name = "lnametxt"
        lnametxt.Size = New Size(265, 29)
        lnametxt.TabIndex = 7
        ' 
        ' mnametxt
        ' 
        mnametxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        mnametxt.Location = New Point(277, 167)
        mnametxt.Name = "mnametxt"
        mnametxt.Size = New Size(265, 29)
        mnametxt.TabIndex = 8
        ' 
        ' fnametxt
        ' 
        fnametxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        fnametxt.Location = New Point(277, 109)
        fnametxt.Name = "fnametxt"
        fnametxt.Size = New Size(265, 29)
        fnametxt.TabIndex = 9
        ' 
        ' SaveInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(633, 399)
        Controls.Add(fnametxt)
        Controls.Add(mnametxt)
        Controls.Add(lnametxt)
        Controls.Add(idtxt)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "SaveInfo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents idtxt As TextBox
    Friend WithEvents lnametxt As TextBox
    Friend WithEvents mnametxt As TextBox
    Friend WithEvents fnametxt As TextBox
End Class
